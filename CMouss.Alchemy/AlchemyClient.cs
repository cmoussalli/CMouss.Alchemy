namespace CMouss.Alchemy
{



    public partial class AlchemyClient
    {

        #region Properties
        string appKey = "";
        string baseURL = "";

        public NFTServices NFTServices;
        
        #endregion


        #region Constructor
        public AlchemyClient(ChainNetwork chainNetwork, string alchemyKey)
        {

            appKey = alchemyKey;
            if (chainNetwork == ChainNetwork.Ethereum_Mainnet) { baseURL = "https://eth-mainnet.alchemyapi.io/v2/" + appKey  + @"/"; }

            NFTServices = new NFTServices(chainNetwork, baseURL);



        }
        #endregion



    }
}