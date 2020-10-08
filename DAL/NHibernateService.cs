using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class NHibernateService
    {
        public static void GenerateShema()
        {
            var cfg = new Configuration();
            cfg.Configure();
           // cfg.AddAssembly(Assembly.GetCallingAssembly());
            cfg.AddAssembly(typeof(NHibernateService).Assembly);

            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static ISession OpenSession()
        {
            Configuration c = new Configuration();
            c.Configure();

            //c.AddAssembly(Assembly.GetCallingAssembly());
            c.AddAssembly(typeof(NHibernateService).Assembly);
            ISessionFactory f = c.BuildSessionFactory();
            return f.OpenSession();
        }
    }
}
