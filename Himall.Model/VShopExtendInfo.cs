//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Himall.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class VShopExtendInfo:BaseModel
    {
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long VShopId { get; set; }
        public Nullable<int> Sequence { get; set; }
        public VShopExtendInfo.VShopExtendType Type { get; set; }
        public System.DateTime AddTime { get; set; }
        public int State { get; set; }
    
        public virtual VShopInfo VShopInfo { get; set; }
    }
}
