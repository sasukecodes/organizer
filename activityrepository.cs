using System;
using System.Collections.Generic;
using System.Linq;
using projectmain.Models;
using SQLite;

namespace projectmain
{
    public class activityrepository
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public activityrepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<activity>();
        }

        public void AddNewActivity(string[] name)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                /*if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");*/

                //string pkey = name[0] + name[1] + name[2];

                result = conn.Insert(new activity { Interval = name[0], Name = name[1], Category = name[2], Categoryno = Convert.ToInt32(name[3]) });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }
        }

        /// <summary>
        /// queries
        /// </summary>
        /// <returns></returns>
        public List<activity> GetAllminion()
        {
            try
            {
                IEnumerable<activity> user = from u in conn.Table<activity>()
                                             orderby u.Interval                                   /////////try commenting
                                             where u.Category == "me"                           //////////////////edit home
                                             select u;
                return user.ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<activity>();
        }

        public List<activity> GetAllwearables()
        {
            try
            {
                IEnumerable<activity> user = from u in conn.Table<activity>()
                                             orderby u.Interval                                   /////////try commenting
                                             where u.Category == "wearables"                           //////////////////edit home
                                             select u;
                return user.ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<activity>();
        }

        public List<activity> GetAllhouse()
        {
            try
            {
                IEnumerable<activity> user = from u in conn.Table<activity>()
                                             orderby u.Interval                                   /////////try commenting
                                             where u.Category == "home"                           //////////////////edit home
                                             select u;
                return user.ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<activity>();
        }

        public List<activity> GetAlltransport()
        {
            try
            {
                IEnumerable<activity> user = from u in conn.Table<activity>()
                                             orderby u.Interval                                   /////////try commenting
                                             where u.Category == "transport"                           //////////////////edit home
                                             select u;
                return user.ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<activity>();
        }

        public List<activity> GetAlloffice()
        {
            try
            {
                IEnumerable<activity> user = from u in conn.Table<activity>()
                                             orderby u.Interval                                   /////////try commenting
                                             where u.Category == "office"                           //////////////////edit home
                                             select u;
                return user.ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<activity>();
        }










        /// <summary>
        /// remove get all events maybe
        /// </summary>
        /// <returns></returns>
        public List<activity> GetAllEvents()
        {
            try
            {
                return conn.Table<activity>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<activity>();
        }

        public void DelActivity(activity act)
        {
            conn.Delete(act);
        }



    }
}