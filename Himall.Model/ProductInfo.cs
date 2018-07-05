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
    
    public partial class ProductInfo:BaseModel
    {
        public ProductInfo()
        {
            this.ProductConsultationInfo = new HashSet<ProductConsultationInfo>();
            this.ProductAttributeInfo = new HashSet<ProductAttributeInfo>();
            this.SKUInfo = new HashSet<SKUInfo>();
            this.Himall_Favorites = new HashSet<FavoriteInfo>();
            this.Himall_FloorProducts = new HashSet<FloorProductInfo>();
            this.Himall_ProductShopCategories = new HashSet<ProductShopCategoryInfo>();
            this.Himall_ShoppingCarts = new HashSet<ShoppingCartItemInfo>();
            this.Himall_ProductComments = new HashSet<ProductCommentInfo>();
            this.Himall_ModuleProducts = new HashSet<ModuleProductInfo>();
            this.Himall_ShopHomeModuleProducts = new HashSet<ShopHomeModuleProductInfo>();
            this.Himall_ProductVistis = new HashSet<ProductVistiInfo>();
            this.Himall_BrowsingHistory = new HashSet<BrowsingHistoryInfo>();
            this.Himall_MobileHomeProducts = new HashSet<MobileHomeProductsInfo>();
            this.Himall_FloorTablDetails = new HashSet<FloorTablDetailsInfo>();
            this.Himall_CollocationPoruducts = new HashSet<CollocationPoruductInfo>();
            this.Himall_CollocationSkus = new HashSet<CollocationSkuInfo>();
            this.Himall_AgentProducts = new HashSet<AgentProductsInfo>();
            this.Himall_FlashSale = new HashSet<FlashSaleInfo>();
            this.Himall_ProductBrokerage = new HashSet<ProductBrokerageInfo>();
        }
    
        long _id;
        public new long Id { get{ return _id; } set{ _id=value; base.Id = value; } }
        public long ShopId { get; set; }
        public long CategoryId { get; set; }
        public string CategoryPath { get; set; }
        public long TypeId { get; set; }
        public long BrandId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ShortDescription { get; set; }
        public ProductInfo.ProductSaleStatus SaleStatus { get; set; }
        public System.DateTime AddedDate { get; set; }
        public long DisplaySequence { get; set; }
        private string imagePath { get; set; }
        public decimal MarketPrice { get; set; }
        public decimal MinSalePrice { get; set; }
        public bool HasSKU { get; set; }
        public long VistiCounts { get; set; }
        public long SaleCounts { get; set; }
        public ProductInfo.ProductAuditStatus AuditStatus { get; set; }
        public long FreightTemplateId { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Volume { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string MeasureUnit { get; set; }
        public int EditStatus { get; set; }
        public bool IsDeleted { get; set; }
        public int MaxBuyCount { get; set; }
    
        public virtual ICollection<ProductConsultationInfo> ProductConsultationInfo { get; set; }
        public virtual ICollection<ProductAttributeInfo> ProductAttributeInfo { get; set; }
        public virtual ProductDescriptionInfo ProductDescriptionInfo { get; set; }
        public virtual ICollection<SKUInfo> SKUInfo { get; set; }
        public virtual ICollection<FavoriteInfo> Himall_Favorites { get; set; }
        public virtual ICollection<FloorProductInfo> Himall_FloorProducts { get; set; }
        public virtual ICollection<ProductShopCategoryInfo> Himall_ProductShopCategories { get; set; }
        internal virtual ICollection<ShoppingCartItemInfo> Himall_ShoppingCarts { get; set; }
        public virtual ICollection<ProductCommentInfo> Himall_ProductComments { get; set; }
        public virtual ICollection<ModuleProductInfo> Himall_ModuleProducts { get; set; }
        public virtual ICollection<ShopHomeModuleProductInfo> Himall_ShopHomeModuleProducts { get; set; }
        public virtual ICollection<ProductVistiInfo> Himall_ProductVistis { get; set; }
        public virtual ICollection<BrowsingHistoryInfo> Himall_BrowsingHistory { get; set; }
        public virtual FreightTemplateInfo Himall_FreightTemplate { get; set; }
        public virtual ICollection<MobileHomeProductsInfo> Himall_MobileHomeProducts { get; set; }
        public virtual ICollection<FloorTablDetailsInfo> Himall_FloorTablDetails { get; set; }
        public virtual CategoryInfo Himall_Categories { get; set; }
        public virtual ICollection<CollocationPoruductInfo> Himall_CollocationPoruducts { get; set; }
        public virtual ICollection<CollocationSkuInfo> Himall_CollocationSkus { get; set; }
        public virtual ICollection<AgentProductsInfo> Himall_AgentProducts { get; set; }
        public virtual ICollection<FlashSaleInfo> Himall_FlashSale { get; set; }
        public virtual ICollection<ProductBrokerageInfo> Himall_ProductBrokerage { get; set; }
        public virtual ShopInfo Himall_Shops { get; set; }
    }
}
