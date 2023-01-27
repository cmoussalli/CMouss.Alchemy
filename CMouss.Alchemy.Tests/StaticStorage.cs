using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMouss.Alchemy.Tests
{
    public static class StaticStorage
    {
        public static string appKey { get; set; } = "QOh4FoCKlgdwNLcCeTTdP4NTdh1MY21R";
        public static ChainNetwork ChainNetwork { get; set; } = ChainNetwork.Ethereum_Mainnet;


        public static string testingWalletAddress { get; set; } = "0x5C12BAc5ff8E6BadC0a807fbe8aa11EDDe8b663e";

        //0x495f947276749Ce646f68AC8c248420045cb7b5e
        //0x9961d31fc342fca7be33cf1b6140dd8a1810d8a1              --NFTUT
        public static string testingNFTContractAddress { get; set; } = "0x9961d31fc342fca7be33cf1b6140dd8a1810d8a1";

        //70797828492686952633133719236762374236848891894038857759543345475233534443521
        //0
        public static string testingNFTTokenId { get; set; } = "0";



    }
}
