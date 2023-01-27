//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CMouss.Alchemy
//{
//    public partial class Models
//    {


//        public class GetNFTsResponse
//        {
//            public Ownednft[] ownedNfts { get; set; }
//            public int totalCount { get; set; }
//            public string blockHash { get; set; }
//        }

//        public class Ownednft
//        {
//            public Contract contract { get; set; }
//            public Id id { get; set; }
//            public string balance { get; set; }
//            public string title { get; set; }
//            public string description { get; set; }
//            public Tokenuri tokenUri { get; set; }
//            public Medium[] media { get; set; }
//            public Metadata metadata { get; set; }
//            public DateTime timeLastUpdated { get; set; }
//        }

//        public class Contract
//        {
//            public string address { get; set; }
//        }

//        public class Id
//        {
//            public string tokenId { get; set; }
//            public Tokenmetadata tokenMetadata { get; set; }
//        }

//        public class Tokenmetadata
//        {
//            public string tokenType { get; set; }
//        }

//        public class Tokenuri
//        {
//            public string raw { get; set; }
//            public string gateway { get; set; }
//        }

//        public class Metadata
//        {
//            public string background_image { get; set; }
//            public bool is_normalized { get; set; }
//            public string image_url { get; set; }
//            public string name { get; set; }
//            public string description { get; set; }
//            public Attribute[] attributes { get; set; }
//            public int name_length { get; set; }
//            public int version { get; set; }
//            public string url { get; set; }
//        }

//        public class Attribute
//        {
//            public string display_type { get; set; }
//            public string trait_type { get; set; }
//            public string value { get; set; }
//        }

//        public class Medium
//        {
//            public string raw { get; set; }
//            public string gateway { get; set; }
//        }




//    }
//}
