using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccSyscOhoda.Entities
{
    public class vnfnCpteReference
    {
        public string RefCode { get; set; }
        public Guid oCompteId { get; set; }
        public Guid oReferenceId { get; set; }
        public Guid oTableauPosteId { get; set; }
        public string TableauName { get; set; }
        public Guid oStableauPosteId { get; set; }
        public string StableauName { get; set; }
        public Guid oStblAreaId { get; set; }
        public string RefCodeDescription { get; set; }
        public string nRefDescription { get; set; }
        public string NumCompte { get; set; }
        public int NumLevel { get; set; }
        public int SortOrder { get; set; }
        public string AreaLongName { get; set; }
        public Boolean Exception { get; set; }
        public decimal Taux { get; set; }

    }
}


//public class TestFunctionParams
//{
//    [CodeFunctionAttributes.FunctionOrder(1)]
//    [CodeFunctionAttributes.Name("id")]
//    [CodeFunctionAttributes.ParameterType(System.Data.SqlDbType.Structured)]
//    public Guid  Id { get; set; }
//}

/*--oReferenceId
--RefCode
--RefCodeDescription
--nRefDescription
--oCompteId
--CompteNumber
--Exception
--Taux
--oStableauPosteId
--StableauName
--oTableauPosteId
--TableauName
--oStblAreaId
--AreaShortName
--NumLevel
--SortOrder
*/