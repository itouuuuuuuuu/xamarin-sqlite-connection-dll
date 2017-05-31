using System.Collections.Generic;
using SQLite.Net;
using Xamarin.Forms;

namespace SamplePCL
{
    class SqliteControll
    {
        static readonly object wObject = new object();
        readonly SQLiteConnection wSQLiteConnection;

        // SQLiteデータベースに接続
        public SqliteControll()
        {
            // 接続
            wSQLiteConnection = DependencyService.Get<ISqliteConnection>().GetConnection();

            // データ管理用テーブル作成
            wSQLiteConnection.CreateTable<SqliteItem>();
        }

        // データの取得
        public IEnumerable<SqliteItem> GetItems() 
        {
            lock (wObject) 
            {
                return wSQLiteConnection.Table<SqliteItem>();
            }
        }

        // データの登録
        public void InsertItem(SqliteItem item)
        {
            lock (wObject)
            {
                wSQLiteConnection.Insert(item);
            }
        }

        // データの削除
        public void DeleteItem(SqliteItem item)
        {
            lock (wObject)
            {
                wSQLiteConnection.Delete(item);
            }
        }
    }

}
