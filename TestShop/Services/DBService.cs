using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using TestShop.Model;

namespace TestShop.Services
{
    public class DBService
    {
        public static void Save(Университет университеты)
        {
            try
            {
                Configuration configuration = new Configuration();
                configuration.Configure();

                ISessionFactory factory = configuration.BuildSessionFactory();

                ISession session = factory.OpenSession();
                ITransaction transaction = session.BeginTransaction();

                session.SaveOrUpdate(университеты);

                transaction.Commit();

                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Save(Факультет факультеты)
        {
           try
            {
                Configuration configuration = new Configuration();
                configuration.Configure();

                ISessionFactory factory = configuration.BuildSessionFactory();

                ISession session = factory.OpenSession();
                ITransaction transaction = session.BeginTransaction();

                session.SaveOrUpdate(факультеты);

                transaction.Commit();

                session.Close();
                session.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
