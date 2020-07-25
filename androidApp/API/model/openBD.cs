namespace androidApp.API.model
{
    public class OpenBDResponce
    {
        public Onix onix { get; set; }
        public Hanmoto hanmoto { get; set; }
        public Summary summary { get; set; }
    }

    public class Onix
    {
        public string RecordReference { get; set; }
        public string NotificationType { get; set; }
        public Productidentifier ProductIdentifier { get; set; }
        public Descriptivedetail DescriptiveDetail { get; set; }
        public Collateraldetail CollateralDetail { get; set; }
        public Publishingdetail PublishingDetail { get; set; }
        public Productsupply ProductSupply { get; set; }
    }

    public class Productidentifier
    {
        public string ProductIDType { get; set; }
        public string IDValue { get; set; }
    }

    public class Descriptivedetail
    {
        public string ProductComposition { get; set; }
        public string ProductForm { get; set; }
        public string ProductFormDetail { get; set; }
        public Titledetail TitleDetail { get; set; }
        public Contributor[] Contributor { get; set; }
        public Language[] Language { get; set; }
        public Extent[] Extent { get; set; }
        public Subject[] Subject { get; set; }
    }

    public class Titledetail
    {
        public string TitleType { get; set; }
        public Titleelement TitleElement { get; set; }
    }

    public class Titleelement
    {
        public string TitleElementLevel { get; set; }
        public Titletext TitleText { get; set; }
        public Subtitle Subtitle { get; set; }
    }

    public class Titletext
    {
        public string collationkey { get; set; }
        public string content { get; set; }
    }

    public class Subtitle
    {
        public string collationkey { get; set; }
        public string content { get; set; }
    }

    public class Contributor
    {
        public string SequenceNumber { get; set; }
        public string[] ContributorRole { get; set; }
        public Personname PersonName { get; set; }
        public string BiographicalNote { get; set; }
    }

    public class Personname
    {
        public string collationkey { get; set; }
        public string content { get; set; }
    }

    public class Language
    {
        public string LanguageRole { get; set; }
        public string LanguageCode { get; set; }
        public string CountryCode { get; set; }
    }

    public class Extent
    {
        public string ExtentType { get; set; }
        public string ExtentValue { get; set; }
        public string ExtentUnit { get; set; }
    }

    public class Subject
    {
        public string SubjectSchemeIdentifier { get; set; }
        public string SubjectCode { get; set; }
    }

    public class Collateraldetail
    {
        public Textcontent[] TextContent { get; set; }
        public Supportingresource[] SupportingResource { get; set; }
    }

    public class Textcontent
    {
        public string TextType { get; set; }
        public string ContentAudience { get; set; }
        public string Text { get; set; }
    }

    public class Supportingresource
    {
        public string ResourceContentType { get; set; }
        public string ContentAudience { get; set; }
        public string ResourceMode { get; set; }
        public Resourceversion[] ResourceVersion { get; set; }
    }

    public class Resourceversion
    {
        public string ResourceForm { get; set; }
        public Resourceversionfeature[] ResourceVersionFeature { get; set; }
        public string ResourceLink { get; set; }
    }

    public class Resourceversionfeature
    {
        public string ResourceVersionFeatureType { get; set; }
        public string FeatureValue { get; set; }
    }

    public class Publishingdetail
    {
        public Imprint Imprint { get; set; }
        public Publishingdate[] PublishingDate { get; set; }
    }

    public class Imprint
    {
        public Imprintidentifier[] ImprintIdentifier { get; set; }
        public string ImprintName { get; set; }
    }

    public class Imprintidentifier
    {
        public string ImprintIDType { get; set; }
        public string IDValue { get; set; }
    }

    public class Publishingdate
    {
        public string PublishingDateRole { get; set; }
        public string Date { get; set; }
    }

    public class Productsupply
    {
        public Supplydetail SupplyDetail { get; set; }
    }

    public class Supplydetail
    {
        public Returnsconditions ReturnsConditions { get; set; }
        public string ProductAvailability { get; set; }
        public Price[] Price { get; set; }
    }

    public class Returnsconditions
    {
        public string ReturnsCodeType { get; set; }
        public string ReturnsCode { get; set; }
    }

    public class Price
    {
        public string PriceType { get; set; }
        public string PriceAmount { get; set; }
        public string CurrencyCode { get; set; }
    }

    public class Hanmoto
    {
        public string toji { get; set; }
        public int zaiko { get; set; }
        public string maegakinado { get; set; }
        public string kaisetsu105w { get; set; }
        public string tsuiki { get; set; }
        public int genrecodetrc { get; set; }
        public string kankoukeitai { get; set; }
        public Jyuhan[] jyuhan { get; set; }
        public bool hastameshiyomi { get; set; }
        public Author[] author { get; set; }
        public string datemodified { get; set; }
        public string datecreated { get; set; }
        public Review[] reviews { get; set; }
        public Hanmotoinfo hanmotoinfo { get; set; }
        public string dateshuppan { get; set; }
    }

    public class Hanmotoinfo
    {
        public string name { get; set; }
        public string yomi { get; set; }
        public string url { get; set; }
        public string twitter { get; set; }
        public string facebook { get; set; }
    }

    public class Jyuhan
    {
        public string date { get; set; }
        public string ctime { get; set; }
        public int suri { get; set; }
        public string comment { get; set; }
    }

    public class Author
    {
        public int listseq { get; set; }
        public string dokujikubun { get; set; }
    }

    public class Review
    {
        public string post_user { get; set; }
        public string reviewer { get; set; }
        public int source_id { get; set; }
        public int kubun_id { get; set; }
        public string source { get; set; }
        public string choyukan { get; set; }
        public string han { get; set; }
        public string link { get; set; }
        public string appearance { get; set; }
        public string gou { get; set; }
    }

    public class Summary
    {
        public string isbn { get; set; }
        public string title { get; set; }
        public string volume { get; set; }
        public string series { get; set; }
        public string publisher { get; set; }
        public string pubdate { get; set; }
        public string cover { get; set; }
        public string author { get; set; }
    }
}