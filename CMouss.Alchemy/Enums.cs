using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMouss.Alchemy
{
    public enum ChainNetwork
    {
        Ethereum_Mainnet = 11,
        Ethereum_Rinkeby = 12,
        Ethereum_Ropsten = 13,
        Ethereum_Kovan = 14,
        Ethereum_Goerli = 15,

        Polygon_Mainnet = 21,
        Polygon_Mumbai = 22,

        Flow_Mainnet = 31

    }


    public enum TokenType
    {
        ERC721 = 1,
        ERC1155 = 2
    }

}
