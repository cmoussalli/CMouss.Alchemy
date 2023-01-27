using Microsoft.VisualStudio.TestTools.UnitTesting;
using CMouss.Alchemy;
using System.Threading.Tasks;

namespace CMouss.Alchemy.Tests
{
    [TestClass]
    public class NFTsTests
    { 
        [TestMethod]
        public async Task GetNFTsAsync()
        {
            AlchemyClient a = new AlchemyClient(ChainNetwork.Ethereum_Mainnet, StaticStorage.appKey);
            AlchemyModels.GetNFTsResponse res = await a.NFTServices.GetNFTsAsync(StaticStorage.testingWalletAddress, null, null);
            Assert.IsNotNull(res);
            Assert.IsTrue(res.totalCount > 0);
        }

        [TestMethod]
        public async Task GetNFTMetadataAsync()
        {
            AlchemyClient a = new AlchemyClient(ChainNetwork.Ethereum_Mainnet, StaticStorage.appKey);
            AlchemyModels.Ownednft res = await a.NFTServices.GetNFTMetadataAsync(StaticStorage.testingNFTContractAddress,StaticStorage.testingNFTTokenId,null);
            Assert.IsNotNull(res);
            Assert.IsTrue(res.title.Length > 0);
        }

        [TestMethod]
        public async Task GetNFTByContractAsync()
        {
            AlchemyClient a = new AlchemyClient(ChainNetwork.Ethereum_Mainnet, StaticStorage.appKey);
            AlchemyModels.GetNFTsForCollectionResponse res = await a.NFTServices.GetNFTByContractAsync(StaticStorage.testingNFTContractAddress, true, null);
            Assert.IsNotNull(res);
            Assert.IsTrue(res.nfts.Length > 0);
        }
    }
}