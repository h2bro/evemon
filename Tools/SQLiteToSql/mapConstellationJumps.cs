//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EVEMon.SQLiteToSql
{
    using System;
    using System.Collections.Generic;
    
    public partial class mapConstellationJumps
    {
        public Nullable<long> fromRegionID { get; set; }
        public long fromConstellationID { get; set; }
        public long toConstellationID { get; set; }
        public Nullable<long> toRegionID { get; set; }
    }
}