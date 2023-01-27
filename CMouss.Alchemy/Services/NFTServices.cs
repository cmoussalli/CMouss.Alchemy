
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Text.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CMouss.Alchemy
{
    public class NFTServices
    {
        string _baseUrl = "";
        ChainNetwork _chainNetwork;


        public NFTServices(ChainNetwork chainNetwork, string baseUrl)
        {
            _chainNetwork = chainNetwork;
            _baseUrl = baseUrl;
        }




        public async Task<AlchemyModels.GetNFTsResponse> GetNFTsAsync(string owner, bool? withMetadata = false, string? pageKey = null)
        {

            HttpClient client = new HttpClient();
            string ps = @"getNFTs?";
            ps = ps + "owner=" + owner;
            if (withMetadata != null){ps = ps + "&withMetadata=" + withMetadata.ToString().ToLower();}
            if (pageKey != null){ps = ps + pageKey.ToString();}
            string resStr = await client.GetStringAsync(_baseUrl + ps);
            //AlchemyModels.GetNFTsResponse res = JsonSerializer.Deserialize<AlchemyModels.GetNFTsResponse>(resStr);

            AlchemyModels.GetNFTsResponse res = JsonConvert.DeserializeObject<AlchemyModels.GetNFTsResponse>(resStr);

            //JsonConvert.DeserializeObject<AlchemyModels.GetNFTsResponse>(resStr);
            return res;
        }

        public async Task<AlchemyModels.Ownednft> GetNFTMetadataAsync(string contractAddress, string tokenId, TokenType? tokenType = null)
        {

            HttpClient client = new HttpClient();
            string ps = @"getNFTMetadata?";
            ps = ps + "contractAddress=" + contractAddress;
            ps = ps + "&tokenId=" + tokenId;
            if (tokenType != null) { if (tokenType == TokenType.ERC721) { ps = ps + "&tokenType=ERC721"; } else { ps = ps + "&tokenType=ERC1155"; } }
            string resStr = await client.GetStringAsync(_baseUrl + ps);
            AlchemyModels.Ownednft res = JsonConvert.DeserializeObject<AlchemyModels.Ownednft>(resStr);
            System.Diagnostics.Debug.WriteLine(res.title);
            return res;
        }

        public async Task<AlchemyModels.GetNFTsForCollectionResponse> GetNFTByContractAsync(string contractAddress, bool? withMetadata = false, string? pageKey = null)
        {

            HttpClient client = new HttpClient();
            string ps = @"getNFTsForCollection?";
            ps = ps + "contractAddress=" + contractAddress;
            if (withMetadata != null) { ps = ps + "&withMetadata=" + withMetadata.ToString(); }
            if (pageKey != null) { ps = ps + pageKey.ToString(); }

            string resStr = await client.GetStringAsync(_baseUrl + ps);
            AlchemyModels.GetNFTsForCollectionResponse res = JsonConvert.DeserializeObject<AlchemyModels.GetNFTsForCollectionResponse>(resStr);
            return res;
        }
    }
}
