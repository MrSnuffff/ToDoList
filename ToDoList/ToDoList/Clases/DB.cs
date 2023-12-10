using System.Collections.Generic;
using SQLite;

namespace ToDoList.Clases
{
    public class DB
    {
        private readonly SQLiteConnection conn;
        public DB(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<item>();
        }

        public List<item> GetItems()
        {
            return conn.Table<item>().ToList();
        }

        public int SaveItem(item _item)
        {
            return conn.Insert(_item);
        }
        public int DeleteItemById(int itemId)
        {
            return conn.Delete<item>(itemId);
        }
    }
}
