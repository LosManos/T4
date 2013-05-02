using System.Collections.Generic;

namespace T4
{
    class PetaPocoExample
    {
        public IEnumerable<MyPocoPetaNameSpace.Omrade> GetOmraden()
        {
            var databaseContext = new PetaPoco.Database("MyConnectionString");
            return databaseContext.Query<MyPocoPetaNameSpace.Omrade>("Select * from Customer");
        }
    }
}
