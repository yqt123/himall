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
    
    public partial class WeiXinMsgTemplateInfo:BaseModel
    {
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public Nullable<int> MessageType { get; set; }
        public string TemplateNum { get; set; }
        public string TemplateId { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public bool IsOpen { get; set; }
        public Nullable<byte> UserInWxApplet { get; set; }
    }
}
