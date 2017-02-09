using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace estadisticas_avima.avima
{

    public partial class AVIMA_Ventas
    {
        public AVIMA_Ventas(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
