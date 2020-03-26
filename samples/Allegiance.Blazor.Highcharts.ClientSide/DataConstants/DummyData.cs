﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allegiance.Blazor.Highcharts.ClientSide.DataConstants
{
    public class DummyData
    {
        public static List<object> LifeStyle { get; } = new List<object>() { 2400019, 2388393, 2376824, 2365311, 2353853, 2342451, 2331105, 2319813, 2308576, 2297393, 2286264, 2275190, 2264169, 2253201, 2242287, 2231425, 2220616, 2209860, 2199155, 2188503, 2177902, 2167352, 2156853, 2146405, 2136008, 2125662, 2115365, 2105118, 2094921, 2084773, 2074675, 2064625, 2054624, 2044672, 2034767, 2024911, 2015102, 2005341, 1995627, 1985961, 1976341, 1966767, 1957240, 1947759, 1938325, 1928935, 1919592, 1910293, 1901040, 1891831, 1882667, 1873548, 1864472, 1855441, 1846453, 1837509, 1828608, 1819750, 1810936, 1802163, 1793434, 1784746, 1776101, 1767498, 1758936, 1750416, 1741937, 1733499, 1725102, 1716746, 1708430, 1700154, 1691919, 1683723, 1675567, 1667451, 1659374, 1651336, 1643337, 1635376, 1627455, 1619571, 1611726, 1603919, 1596150, 1588418, 1580724, 1573067, 1565447, 1557864, 1550318, 1542808, 1535335, 1527898, 1520496, 1513131, 1505802, 1498508, 1491249, 1484025, 1476837, 1469683, 1462564, 1455479, 1448429, 1441413, 1434431, 1427482, 1420568, 1413686, 1406839, 1400024, 1393242, 1386493, 1379777, 1373094, 1366442, 1359823, 1353236, 1346681, 1340158, 1333666, 1327206, 1320777, 1314379, 1308013, 1301677, 1295371, 1289097, 1282852, 1276638, 1270454, 1264300, 1258176, 1252081, 1246016, 1239981, 1233974, 1227997, 1222048, 1216129, 1210238, 1204376, 1198542, 1192736, 1186958, 1181209, 1175487, 1169793, 1164127, 1158488, 1152876, 1147291, 1141734, 1136203, 1130700, 1125223, 1119772, 1114348, 1108950, 1103578, 1098233, 1092913, 1087619, 1082350, 1077107, 1071890, 1066698, 1061531, 1056389, 1051272, 1046179, 1041112, 1036068, 1031050, 1026055, 1021085, 1016139, 1011217, 1006319, 1001444, 996593, 991766, 986962, 982181, 977423, 972688, 967977, 963288, 958622, 953978, 949357, 944759, 940182, 935628, 931096, 926586, 922097, 917631, 913186, 908762, 904360, 899979, 895620, 891282, 886964, 882668, 878392, 874137, 869903, 865689, 861496, 857323, 853170, 849037, 844925, 840832, 836759, 832706, 828672, 824658, 820663, 816688, 812732, 808795, 804877, 800979, 797099, 793238, 789395, 785571, 781766, 777979, 774211, 770460, 766728, 763014, 759318, 755640, 751980, 748337, 744712, 741105, 737515, 733943, 730387, 726849, 723329, 719825, 716338, 712868, 709415, 705979, 702559, 699156, 695769, 692399, 689045, 685707, 682385, 679080, 675791, 672517, 669259, 666018, 662791, 659581, 656386, 653206, 650042, 646893, 643760, 640641, 637538, 634450, 631377, 628318, 625275, 622246, 619232, 616232, 613247, 610277, 607321, 604379, 601451, 598538, 595638, 592753, 589882, 587025, 584181, 581351, 578535, 575733, 572944, 570169, 567407, 564658, 561923, 559201, 556492, 553797, 551114, 548445, 545788, 543144, 540513, 537895, 535289, 532696, 530116, 527548, 524993, 522450, 519919, 517401, 514894, 512400, 509918, 507448, 504990, 502544, 500110, 497687, 495276, 492877, 490490, 488114, 485749, 483396, 481055, 478725, 476406, 474098, 471801, 469516, 467242, 464978, 462726, 460485, 458254, 456034, 453825, 451627, 449439, 447262, 445096, 442940, 440794, 438659, 436534, 434419, 432315, 430221, 428137, 426063, 423999, 421946, 419902, 417868, 415843, 413829, 411825, 409830, 407845, 405869, 403903, 401946, 399999, 398062, 396134, 394215, 392305, 390405, 388514, 386632, 384759, 382895, 381040, 379195, 377358, 375530, 373711, 371901, 370099, 368306, 366522, 364747, 362980, 361222, 359472, 357731, 355998, 354274, 352557, 350850, 349150, 347459, 345776, 344101, 342434, 340775, 339125, 337482, 335847, 334220, 332601, 330990, 329387, 327791, 326204, 324624, 323051, 321486, 319929, 318379, 316837, 315302, 313775, 312255, 310742, 309237, 307739, 306249, 304765, 303289, 301820, 300358, 298903, 297455, 296014, 294580, 293153, 291733, 290320, 288914, 287514, 286122, 284736, 283356, 281984, 280618, 279259, 277906, 276560, 275220, 273887, 272560, 271240, 269926, 268618, 267317, 266022, 264734, 263451, 262175, 260905, 259642, 258384, 257132, 255887, 254647, 253414, 252186, 250965, 249749, 248539, 247335, 246137, 244945, 243758, 242578, 241403, 240233, 239070, 237911, 236759, 235612, 234471, 233335, 232205, 231080, 229961, 228847, 227738, 226635, 225537, 224445, 223358, 222276, 221199, 220127, 219061, 218000, 216944, 215893, 214847, 213807, 212771, 211740, 210715, 209694, 208678, 207667, 206661, 205660, 204664, 203673, 202686, 201704, 200727, 199755, 198787, 197825, 196866, 195913, 194964, 194019, 193079, 192144, 191213, 190287, 189365, 188448, 187535, 186627, 185723, 184823, 183928, 183037, 182150, 181268, 180390, 179516, 178647, 177781, 176920, 176063, 175210, 174362, 173517, 172676, 171840, 171008, 170179, 169355, 168535, 167718, 166906, 166097, 165293, 164492, 163695, 162902, 162113, 161328, 160546, 159769, 158995, 158225, 157458, 156696, 155937, 155181, 154429, 153681, 152937, 152196, 151459, 150725, 149995, 149269, 148546, 147826, 147110, 146397, 145688, 144982, 144280, 143581, 142886, 142194, 141505, 140819, 140137, 139458, 138783, 138111, 137442, 136776, 136113, 135454, 134798, 134145, 133495, 132849, 132205, 131565, 130927, 130293, 129662, 129034, 128409, 127787, 127168, 126552, 125939, 125329, 124722, 124118, 123516, 122918, 122323, 121730, 121140, 120554, 119970, 119389, 118810, 118235, 117662, 117092, 116525, 115960, 115399, 114840, 114283, 113730, 113179, 112631, 112085, 111542, 111002, 110464, 109929, 109397, 108867, 108339, 107815, 107292, 106773, 106255, 105741, 105228, 104719, 104211, 103707, 103204, 102704, 102207, 101712, 101219, 100729, 100241, 99755, 99272, 98791, 98313, 97837, 97363, 96891, 96422, 95955, 95490, 95027, 94567, 94109, 93653, 93199, 92748, 92299, 91851, 91407, 90964, 90523, 90085, 89648, 89214, 88782, 88352, 87924, 87498, 87074, 86652, 86233, 85815, 85399, 84986, 84574, 84164, 83757, 83351, 82947, 82545, 82145, 81748, 81352, 80957, 80565, 80175, 79787, 79400, 79016, 78633, 78252, 77873, 77496, 77120, 76747, 76375, 76005, 75637, 75270, 74906, 74543, 74182, 73823, 73465, 73109, 72755, 72403, 72052, 71703, 71356, 71010, 70666, 70324, 69983, 69644, 69307, 68971, 68637, 68304, 67973, 67644, 67317, 66990, 66666, 66343, 66022, 65702, 65384, 65067, 64752, 64438, 64126 };
        public static List<object> Retirement { get; } = new List<object>() { 4406, 8791, 13155, 17497, 21819, 26120, 30400, 34660, 38898, 43116, 47314, 51491, 55897, 60282, 64646, 68988, 73309, 77610, 81889, 86149, 90387, 94604, 98802, 102979, 107385, 111770, 116133, 120476, 124798, 129099, 133378, 137637, 141876, 146094, 150292, 154469, 158876, 163261, 167626, 171969, 176291, 180591, 184871, 189131, 193370, 197588, 201786, 205963, 210369, 214754, 219118, 223461, 227782, 232083, 236363, 240621, 244860, 249078, 253275, 257453, 261859, 266243, 270607, 274949, 279271, 283571, 287851, 292110, 296348, 300565, 304763, 308940, 313347, 317731, 322095, 326438, 330759, 335060, 339339, 343599, 347837, 352055, 356252, 360429, 364835, 369220, 373583, 377926, 382247, 386548, 390827, 395086, 399325, 403543, 407740, 411917, 416323, 420708, 425072, 429415, 433736, 438037, 442317, 446576, 450814, 455032, 459229, 463406, 467812, 472197, 476560, 480903, 485224, 489525, 493805, 498063, 502302, 506519, 510717, 514894, 519300, 523684, 528047, 532390, 536711, 541011, 545290, 549549, 553787, 558004, 562201, 566378, 570784, 575169, 579532, 583874, 588196, 592496, 596775, 601034, 605272, 609489, 613686, 617863, 622268, 626653, 631016, 635358, 639679, 643979, 648257, 652516, 656754, 660971, 665167, 669344, 673749, 678133, 682496, 686838, 691158, 695458, 699737, 703995, 708233, 712450, 716647, 720823, 725229, 729612, 733975, 738317, 742638, 746938, 751216, 755475, 759712, 763929, 768126, 772302, 776708, 781092, 785455, 789797, 794118, 798418, 802697, 806956, 811193, 815410, 819607, 823784, 828189, 832573, 836936, 841277, 845598, 849897, 854176, 858435, 862672, 866889, 871086, 875262, 879667, 884051, 888413, 892755, 897076, 901375, 905654, 909912, 914149, 918366, 922563, 926739, 931144, 935528, 939890, 944232, 948552, 952852, 957130, 961388, 965626, 969842, 974039, 978215, 982620, 987004, 991366, 995708, 1000029, 1004328, 1008607, 1012865, 1017102, 1021319, 1025516, 1029692, 1034097, 1038481, 1042844, 1047186, 1051506, 1055806, 1060085, 1064343, 1068580, 1072797, 1076994, 1081170, 1085576, 1089960, 1094323, 1098665, 1102986, 1107285, 1111564, 1115822, 1120060, 1124277, 1128474, 1132650, 1137055, 1141439, 1145802, 1150144, 1154465, 1158764, 1163043, 1167301, 1171539, 1175756, 1179952, 1184129, 1188534, 1192918, 1197281, 1201623, 1205944, 1210243, 1214522, 1218780, 1223018, 1227235, 1231432, 1235608, 1240013, 1244397, 1248760, 1253102, 1257423, 1261722, 1266001, 1270260, 1274497, 1278714, 1282911, 1287088, 1291493, 1295877, 1300240, 1304582, 1308902, 1313202, 1317481, 1321739, 1325977, 1330194, 1334391, 1338567, 1342972, 1347356, 1351719, 1356061, 1360382, 1364682, 1368961, 1373219, 1377457, 1381674, 1385870, 1390047, 1394452, 1398836, 1403199, 1407541, 1411862, 1416162, 1420441, 1424699, 1428937, 1433154, 1437351, 1441527, 1445933, 1450317, 1454680, 1459022, 1463343, 1467643, 1471922, 1476180, 1480418, 1484635, 1488832, 1493008, 1497414, 1501798, 1506161, 1510503, 1514824, 1519124, 1523404, 1527662, 1531900, 1536117, 1540314, 1544491, 1548896, 1553280, 1557644, 1561985, 1566306, 1570606, 1574885, 1579144, 1583381, 1587599, 1591795, 1595972, 1600377, 1604762, 1609125, 1613467, 1617788, 1622088, 1626367, 1630625, 1634863, 1639080, 1643277, 1647453, 1651859, 1656243, 1660606, 1664948, 1669269, 1673570, 1677849, 1682107, 1686345, 1690562, 1694759, 1698936, 1703342, 1707726, 1712089, 1716431, 1720752, 1725052, 1729332, 1733590, 1737828, 1742045, 1746242, 1750419, 1754825, 1759209, 1763572, 1767915, 1772236, 1776536, 1780815, 1785074, 1789312, 1793529, 1797726, 1801903, 1806309, 1810693, 1815056, 1819399, 1823720, 1828020, 1832299, 1836558, 1840796, 1845013, 1849210, 1853387, 1857793, 1862178, 1866541, 1870883, 1875204, 1879505, 1883784, 1888043, 1892281, 1896498, 1900695, 1904872, 1909278, 1913662, 1912678, 1911694, 1910711, 1909728, 1908746, 1907764, 1906783, 1905802, 1904822, 1903842, 1902863, 1901884, 1900906, 1899929, 1898951, 1897974, 1896998, 1896023, 1895047, 1894072, 1893098, 1892125, 1891151, 1890179, 1889207, 1888235, 1887264, 1886293, 1885323, 1884353, 1883384, 1882415, 1881447, 1880479, 1879512, 1878545, 1877579, 1876613, 1875648, 1874683, 1873719, 1872755, 1871792, 1870829, 1869867, 1868905, 1867944, 1866983, 1866023, 1865063, 1864104, 1863145, 1862186, 1861229, 1860271, 1859315, 1858358, 1857402, 1856447, 1855492, 1854538, 1853584, 1852630, 1851678, 1850725, 1849773, 1848822, 1847871, 1846920, 1845970, 1845021, 1844072, 1843123, 1842175, 1841228, 1840281, 1839334, 1838388, 1837443, 1836498, 1835553, 1834609, 1833665, 1832722, 1831779, 1830837, 1829896, 1828954, 1828014, 1827073, 1826134, 1825194, 1824256, 1823317, 1822379, 1821442, 1820505, 1819569, 1818633, 1817698, 1816763, 1815828, 1814894, 1813961, 1813028, 1812095, 1811163, 1810232, 1809301, 1808370, 1807440, 1806510, 1805581, 1804652, 1803724, 1802796, 1801869, 1800942, 1800016, 1799090, 1798165, 1797240, 1796315, 1795392, 1794468, 1793545, 1792623, 1791701, 1790779, 1789858, 1788937, 1788017, 1787097, 1786178, 1785260, 1784341, 1783423, 1782506, 1781589, 1780673, 1779757, 1778842, 1777927, 1777012, 1776098, 1775185, 1774272, 1773359, 1772447, 1771535, 1770624, 1769713, 1768803, 1767893, 1766984, 1766075, 1765167, 1764259, 1763351, 1762444, 1761538, 1760632, 1759726, 1758821, 1757916, 1757012, 1756109, 1755205, 1754302, 1753400, 1752498, 1751597, 1750696, 1749795, 1748895, 1747996, 1747097, 1746198, 1745300, 1744402, 1743505, 1742608, 1741712, 1740816, 1739921, 1739026, 1738131, 1737237, 1736344, 1735451, 1734558, 1733666, 1732774, 1731883, 1730992, 1730102, 1729212, 1728323, 1727434, 1726545, 1725657, 1724769, 1723882, 1722996, 1722109, 1721224, 1720338, 1719453, 1718569, 1717685, 1716802, 1715919, 1715036, 1714154, 1713272, 1712391, 1711510, 1710630, 1709750, 1708871, 1707992, 1707113, 1706235, 1705357, 1704480, 1703604, 1702727, 1701851, 1700976, 1700101, 1699227, 1698353, 1697479, 1696606, 1695734, 1694861, 1693990, 1693118, 1692247, 1691377, 1690507, 1689638, 1688768, 1687900, 1687032, 1686164, 1685297, 1684430, 1683563, 1682698, 1681832, 1680967, 1680102, 1679238, 1678375, 1677511, 1676648, 1675786, 1674924, 1674063, 1673202, 1672341, 1671481, 1670621, 1669762, 1668903, 1668045, 1667187, 1666329, 1665472, 1664615, 1663759, 1662903, 1662048, 1661193, 1660339, 1659485, 1658631, 1657778, 1656926, 1656073, 1655221, 1654370, 1653519, 1652669, 1651819, 1650969, 1650120, 1649271, 1648423, 1647575, 1646727, 1645880, 1645034, 1644188, 1643342, 1642497, 1641652, 1640808, 1639964, 1639120 };
        public static List<object> Discretionary { get; } = new List<object>() { 10000, 9985, 9971, 9956, 9941, 9927, 9913, 9899, 9884, 9870, 9856, 9841, 9826, 9812, 9798, 9784, 9770, 9756, 9741, 9727, 9712, 9698, 9684, 9670, 9656, 9642, 9628, 9614, 9600, 9586, 9572, 9558, 9545, 9531, 9517, 9503, 9489, 9475, 9462, 9448, 9434, 9421, 9407, 9393, 9379, 9366, 9352, 9339, 9325, 9312, 9298, 9284, 9271, 9258, 9245, 9231, 9218, 9204, 9190, 9177, 9164, 9151, 9138, 9125, 9111, 9098, 9085, 9072, 9059, 9046, 9033, 9019, 9006, 8993, 8980, 8967, 8954, 8941, 8928, 8915, 8902, 8889, 8877, 8864, 8851, 8837, 8824, 8812, 8799, 8786, 8773, 8761, 8747, 8735, 8723, 8710, 8697, 8684, 8672, 8659, 8647, 8634, 8622, 8609, 8596, 8584, 8572, 8559, 8547, 8534, 8522, 8510, 8498, 8485, 8473, 8460, 8448, 8436, 8424, 8412, 8399, 8387, 8375, 8363, 8351, 8339, 8326, 8314, 8302, 8290, 8278, 8266, 8254, 8242, 8230, 8218, 8206, 8194, 8182, 8170, 8158, 8146, 8134, 8123, 8111, 8099, 8087, 8076, 8064, 8052, 8040, 8029, 8017, 8005, 7994, 7982, 7971, 7959, 7948, 7936, 7925, 7913, 7902, 7890, 7879, 7867, 7856, 7845, 7833, 7822, 7810, 7799, 7788, 7776, 7765, 7754, 7743, 7731, 7720, 7709, 7698, 7687, 7675, 7664, 7653, 7642, 7631, 7620, 7609, 7598, 7587, 7576, 7565, 7554, 7543, 7532, 7521, 7510, 7499, 7488, 7477, 7466, 7456, 7445, 7434, 7423, 7412, 7401, 7391, 7380, 7369, 7359, 7348, 7337, 7326, 7316, 7305, 7295, 7284, 7274, 7263, 7253, 7242, 7232, 7221, 7211, 7200, 7190, 7179, 7169, 7158, 7148, 7138, 7128, 7117, 7107, 7097, 7086, 7076, 7066, 7056, 7045, 7035, 7025, 7015, 7004, 6994, 6984, 6974, 6964, 6953, 6943, 6933, 6923, 6913, 6903, 6893, 6883, 6873, 6863, 6853, 6843, 6833, 6823, 6813, 6803, 6794, 6784, 6774, 6764, 6754, 6744, 6735, 6725, 6715, 6705, 6696, 6686, 6676, 6666, 6657, 6647, 6637, 6628, 6618, 6609, 6599, 6589, 6580, 6570, 6561, 6551, 6542, 6532, 6523, 6513, 6504, 6494, 6485, 6475, 6466, 6457, 6447, 6438, 6429, 6419, 6410, 6401, 6391, 6382, 6373, 6364, 6354, 6345, 6336, 6326, 6317, 6308, 6299, 6290, 6281, 6272, 6263, 6254, 6244, 6235, 6226, 6217, 6208, 6199, 6190, 6181, 6172, 6163, 6154, 6145, 6137, 6128, 6119, 6110, 6101, 6092, 6083, 6074, 6065, 6057, 6048, 6039, 6030, 6022, 6013, 6004, 5995, 5987, 5978, 5969, 5961, 5952, 5943, 5935, 5926, 5917, 5909, 5900, 5892, 5883, 5875, 5866, 5857, 5849, 5841, 5832, 5823, 5815, 5807, 5798, 5790, 5781, 5773, 5764, 5756, 5748, 5739, 5731, 5723, 5714, 5706, 5698, 5690, 5681, 5673, 5665, 5657, 5648, 5640, 5632, 5624, 5616, 5608, 5599, 5591, 5583, 5575, 5567, 5559, 5551, 5543, 5535, 5527, 5519, 5511, 5502, 5494, 5486, 5478, 5470, 5463, 5455, 5447, 5439, 5431, 5423, 5415, 5407, 5399, 5392, 5384, 5376, 5368, 5360, 5353, 5345, 5337, 5329, 5322, 5314, 5306, 5298, 5291, 5283, 5275, 5268, 5260, 5252, 5245, 5237, 4635, 4646, 4657, 4668, 4678, 4689, 4700, 4711, 4722, 4733, 4744, 4755, 4766, 4777, 4789, 4800, 4811, 4822, 4833, 4845, 4856, 4867, 4879, 4890, 4901, 4913, 4924, 4936, 4947, 4959, 4970, 4982, 4993, 5005, 5017, 5028, 5040, 5052, 5064, 5075, 5087, 5099, 5111, 5123, 5135, 5147, 5159, 5171, 5183, 5195, 5207, 5219, 5231, 5243, 5255, 5268, 5280, 5292, 5304, 5317, 5329, 5342, 5354, 5366, 5379, 5391, 5404, 5417, 5429, 5442, 5455, 5467, 5480, 5493, 5506, 5518, 5531, 5544, 5557, 5570, 5583, 5596, 5609, 5622, 5635, 5648, 5661, 5675, 5688, 5701, 5714, 5728, 5741, 5754, 5768, 5781, 5795, 5808, 5822, 5835, 5849, 5862, 5876, 5890, 5903, 5917, 5931, 5945, 5959, 5972, 5986, 6000, 6014, 6028, 6042, 6056, 6070, 6085, 6099, 6113, 6127, 6141, 6156, 6170, 6185, 6199, 6213, 6228, 6242, 6257, 6271, 6286, 6301, 6315, 6330, 6345, 6360, 6374, 6389, 6404, 6419, 6434, 6449, 6464, 6479, 6494, 6509, 6524, 6540, 6555, 6570, 6585, 6601, 6616, 6631, 6647, 6662, 6678, 6693, 6709, 6725, 6740, 6756, 6772, 6787, 6803, 6819, 6835, 6851, 6867, 6883, 6899, 6915, 6931, 6947, 6963, 6980, 6996, 7012, 7029, 7045, 7061, 7078, 7094, 7111, 7127, 7144, 7161, 7177, 7194, 7211, 7227, 7244, 7261, 7278, 7295, 7312, 7329, 7346, 7363, 7380, 7398, 7415, 7432, 7449, 7467, 7484, 7502, 7519, 7536, 7554, 7572, 7589, 7607, 7625, 7642, 7660, 7678, 7696, 7714, 7732, 7750, 7768, 7786, 7804, 7822, 7840, 7859, 7877, 7895, 7914, 7932, 7951, 7969, 7988, 8006, 8025, 8044, 8062, 8081, 8100, 8119, 8138, 8157, 8176, 8195, 8214, 8233, 8252, 8271, 8290, 8310, 8329, 8349, 8368, 8387, 8407, 8426, 8446, 8466, 8485, 8505, 8525, 8545, 8565, 8585, 8605, 8625, 8645, 8665, 8685, 8705, 8726, 8746, 8766, 8787, 8807, 8828, 8848, 8869, 8889, 8910, 8931, 8952, 8973, 8993, 9014, 9035, 9056, 9077, 9099, 9120, 9141, 9162, 9184, 9205, 9226, 9248, 9270, 9291, 9313 };
        public static List<object> Businessasset { get; } = new List<object>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static List<object> Property { get; } = new List<object>() { 3600000, 3605612, 3611234, 3616864, 3622502, 3628148, 3633804, 3639468, 3645142, 3650824, 3656516, 3662216, 3667925, 3673644, 3679370, 3685106, 3690850, 3696604, 3702367, 3708138, 3713919, 3719708, 3725507, 3731314, 3737131, 3742957, 3748792, 3754636, 3760490, 3766352, 3772223, 3778104, 3783993, 3789892, 3795800, 3801717, 3807644, 3813580, 3819525, 3825479, 3831443, 3837415, 3843397, 3849389, 3855390, 3861400, 3867420, 3873449, 3879487, 3885534, 3891592, 3897658, 3903734, 3909820, 3915914, 3922019, 3928133, 3934256, 3940390, 3946532, 3952685, 3958846, 3965018, 3971199, 3977389, 3983590, 3989799, 3996019, 4002248, 4008487, 4014736, 4020995, 4027263, 4033541, 4039829, 4046127, 4052434, 4058752, 4065079, 4071416, 4077763, 4084120, 4090486, 4096863, 4103250, 4109646, 4116053, 4122469, 4128896, 4135333, 4141779, 4148236, 4154702, 4161179, 4167665, 4174162, 4180669, 4187187, 4193714, 4200252, 4206799, 4213357, 4219925, 4226503, 4233092, 4239691, 4246300, 4252920, 4259550, 4266190, 4272841, 4279502, 4286173, 4292854, 4299547, 4306249, 4312962, 4319685, 4326419, 4333164, 4339918, 4346684, 4353460, 4360247, 4367044, 4373852, 4380671, 4387500, 4394339, 4401190, 4408050, 4414922, 4421804, 4428697, 4435601, 4442516, 4449441, 4456377, 4463325, 4470282, 4477251, 4484230, 4491221, 4498222, 4505235, 4512258, 4519292, 4526337, 4533392, 4540460, 4547538, 4554627, 4561727, 4568838, 4575960, 4583094, 4590238, 4597394, 4604561, 4611739, 4618928, 4626129, 4633340, 4640563, 4647797, 4655043, 4662300, 4669568, 4676847, 4684138, 4691440, 4698754, 4706078, 4713415, 4720762, 4728122, 4735492, 4742874, 4750268, 4757673, 4765090, 4772518, 4779958, 4787409, 4794872, 4802347, 4809833, 4817332, 4824841, 4832363, 4839896, 4847441, 4854997, 4862565, 4870146, 4877738, 4885341, 4892957, 4900585, 4908224, 4915876, 4923539, 4931214, 4938902, 4946601, 4954312, 4962035, 4969771, 4977518, 4985277, 4993049, 5000832, 5008628, 5016436, 5024256, 5032089, 5039933, 5047790, 5055659, 5063540, 5071433, 5079339, 5087257, 5095188, 5103131, 5111086, 5119054, 5127034, 5135026, 5143031, 5151049, 5159079, 5167121, 5175176, 5183244, 5191324, 5199416, 5207522, 5215639, 5223770, 5231913, 5240070, 5248238, 5256420, 5264614, 5272821, 5281041, 5289273, 5297519, 5305777, 5314048, 5322332, 5330629, 5338939, 5347261, 5355597, 5363946, 5372308, 5380682, 5389070, 5397471, 5405885, 5414312, 5422753, 5431206, 5439673, 5448153, 5456646, 5465152, 5473672, 5482204, 5490751, 5499310, 5507883, 5516469, 5525069, 5533681, 5542308, 5550948, 5559601, 5568268, 5576948, 5585642, 5594350, 5603071, 5611805, 5620554, 5629315, 5638091, 5646880, 5655683, 5664500, 5673330, 5682174, 5691032, 5699904, 5708789, 5717689, 5726602, 5735529, 5744470, 5753425, 5762394, 5771377, 5780374, 5789385, 5798410, 5807449, 5816503, 5825570, 5834651, 5843747, 5852857, 5861981, 5871119, 5880271, 5889438, 5898619, 5907814, 5917024, 5926248, 5935486, 5944739, 5954006, 5963288, 5972584, 5981895, 5991220, 6000559, 6009914, 6019283, 6028666, 6038064, 6047476, 6056904, 6066346, 6075803, 6085274, 6094761, 6104262, 6113777, 6123308, 6132854, 6142414, 6151990, 6161580, 6171185, 6180805, 6190441, 6200091, 6209756, 6219436, 6229132, 6238843, 6248568, 6258309, 6268065, 6277836, 6287623, 6297424, 6307241, 6317074, 6326921, 6336784, 6346663, 6356556, 6366466, 6376390, 6386330, 6396286, 6406257, 6416244, 6426246, 6436264, 6446297, 6456346, 6466411, 6476491, 6486587, 6496699, 6506827, 6516970, 6527130, 6537305, 6547496, 6557703, 6567925, 6578164, 6588419, 6598689, 6608976, 6619279, 6629597, 6639932, 6650283, 6660650, 6671033, 6681433, 6691848, 6702280, 6712728, 6723193, 6733673, 6744171, 6754684, 6765214, 6775760, 6786323, 6796902, 6807498, 6818110, 6828738, 6839384, 6850046, 6860724, 6871419, 6882131, 6892859, 6903605, 6914367, 6925145, 6935941, 6946753, 6957582, 6968429, 6979292, 6990172, 7001069, 7011983, 7022913, 7033861, 7044826, 7055809, 7066808, 7077824, 7088858, 7099908, 7110976, 7122062, 7133164, 7144284, 7155421, 7166576, 7177748, 7188937, 7200144, 7211368, 7222610, 7233869, 7245146, 7256440, 7267752, 7279082, 7290429, 7301794, 7313177, 7324577, 7335995, 7347431, 7358885, 7370357, 7381847, 7393354, 7404880, 7416423, 7427984, 7439564, 7451161, 7462777, 7474410, 7486062, 7497732, 7509420, 7521127, 7532851, 7544594, 7556355, 7568135, 7579933, 7591749, 7603584, 7615437, 7627309, 7639199, 7651108, 7663035, 7674981, 7686945, 7698928, 7710930, 7722950, 7734990, 7747048, 7759124, 7771220, 7783335, 7795468, 7807620, 7819792, 7831982, 7844191, 7856419, 7868667, 7880933, 7893218, 7905523, 7917847, 7930190, 7942552, 7954934, 7967335, 7979755, 7992195, 8004654, 8017132, 8029630, 8042147, 8054684, 8067240, 8079816, 8092412, 8105027, 8117662, 8130316, 8142991, 8155685, 8168399, 8181132, 8193886, 8206659, 8219452, 8232266, 8245099, 8257952, 8270825, 8283718, 8296632, 8309565, 8322519, 8335493, 8348487, 8361502, 8374536, 8387591, 8400667, 8413762, 8426878, 8440015, 8453172, 8466350, 8479548, 8492766, 8506006, 8519266, 8532546, 8545848, 8559170, 8572513, 8585876, 8599261, 8612666, 8626092, 8639539, 8653007, 8666496, 8680006, 8693538, 8707090, 8720663, 8734258, 8747874, 8761511, 8775169, 8788848, 8802549, 8816272, 8830015, 8843780, 8857567, 8871375, 8885204, 8899055, 8912928, 8926822, 8940738, 8954676, 8968635, 8982616, 8996619, 9010644, 9024691, 9038759, 9052850, 9066962, 9081096, 9095253, 9109431, 9123632, 9137855, 9152100, 9166367, 9180656, 9194968, 9209302, 9223658, 9238037, 9252438, 9266861, 9281307, 9295776, 9310267, 9324781, 9339317, 9353876, 9368458, 9383062, 9397689, 9412339, 9427012, 9441708, 9456426, 9471168, 9485932, 9500720, 9515531, 9530364, 9545221, 9560101, 9575004, 9589931, 9604880, 9619853, 9634850, 9649869, 9664912, 9679979, 9695069, 9710183, 9725320, 9740480, 9755665, 9770873, 9786104, 9801360, 9816639, 9831942, 9847269, 9862620, 9877995, 9893393, 9908816, 9924263, 9939734, 9955229, 9970748, 9986291, 10001859, 10017451, 10033067, 10048707, 10064372, 10080061, 10095775, 10111513, 10127276, 10143063, 10158875, 10174712, 10190573, 10206459, 10222370, 10238305, 10254266, 10270251, 10286261, 10302296, 10318357, 10334442, 10350552, 10366688, 10382848, 10399034, 10415245, 10431481, 10447743, 10464029, 10480342, 10496679, 10513043, 10529431, 10545846, 10562285, 10578751, 10595242, 10611759, 10628301, 10644870, 10661464, 10678084, 10694730, 10711402, 10728100, 10744824, 10761574, 10778350, 10795152, 10811981, 10828835, 10845716, 10862624, 10879557, 10896517, 10913504, 10930517, 10947556, 10964622, 10981715, 10998834, 11015980, 11033153, 11050352, 11067579, 11084832, 11102112, 11119419, 11136753, 11154114, 11171502, 11188917, 11206359, 11223829, 11241326, 11258850, 11276401, 11293980, 11311586, 11329219, 11346880, 11364569, 11382285, 11400029, 11417800, 11435599, 11453426, 11471281, 11489163, 11507074 };
        public static List<object> Debt { get; } = new List<object>() { 5371268, 5316387, 5261641, 5207028, 5152546, 5098196, 5043975, 4989882, 4935917, 4882077, 4828362, 4774769, 4717021, 4659396, 4601893, 4544511, 4487250, 4430107, 4373082, 4316172, 4259377, 4202696, 4146127, 4089669, 4029040, 3968522, 3908115, 3847816, 3787624, 3727538, 3667558, 3607679, 3547903, 3488227, 3428650, 3369171, 3305508, 3241944, 3178477, 3115104, 3051825, 2988639, 2925544, 2862539, 2799620, 2736790, 2674044, 2611382, 2544522, 2477747, 2411055, 2344444, 2317406, 2290449, 2263571, 2236772, 2210052, 2183410, 2156846, 2130360, 2088777, 2060381, 2032063, 2003823, 1975660, 1947573, 1919563, 1891628, 1863767, 1835982, 1808270, 1780631, 1751065, 1721574, 1692159, 1662817, 1633549, 1604354, 1575231, 1546180, 1517200, 1488291, 1459452, 1430683, 1399982, 1369354, 1338795, 1308308, 1277890, 1247542, 1217262, 1187051, 1156907, 1126830, 1096819, 1066874, 1034995, 1003182, 971437, 939759, 908147, 876600, 845118, 813700, 782346, 751055, 719826, 688659, 655554, 622512, 589533, 556617, 523763, 490970, 458239, 425567, 392954, 360401, 327906, 295470, 261089, 226769, 192508, 158304, 124159, 90071, 56040, 22065, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static List<long?> Ticks { get; } = new List<long?>() { 0, 14, 26, 38, 50, 62, 74, 86, 98, 110, 122, 134, 146, 158, 170, 182, 194, 206, 218, 230, 242, 254, 266, 278, 290, 302, 314, 326, 338, 350, 362, 374, 386, 398, 410, 422, 434, 446, 458, 470, 482, 494, 506, 518, 530, 542, 554, 566, 578, 590, 602, 614, 626, 638, 650, 662, 674, 686, 698, 710, 722, 734, 746 };
        public static List<object> Categories { get; } = new List<object>() { 27, 27, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 35, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 38, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 39, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 40, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 43, 43, 43, 43, 43, 43, 43, 43, 43, 43, 43, 43, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 44, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 46, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 49, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 51, 51, 51, 51, 51, 51, 51, 51, 51, 51, 51, 51, 52, 52, 52, 52, 52, 52, 52, 52, 52, 52, 52, 52, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 53, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 54, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 56, 56, 56, 56, 56, 56, 56, 56, 56, 56, 56, 56, 57, 57, 57, 57, 57, 57, 57, 57, 57, 57, 57, 57, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 67, 67, 67, 67, 67, 67, 67, 67, 67, 67, 67, 67, 68, 68, 68, 68, 68, 68, 68, 68, 68, 68, 68, 68, 69, 69, 69, 69, 69, 69, 69, 69, 69, 69, 69, 69, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 70, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 72, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 73, 74, 74, 74, 74, 74, 74, 74, 74, 74, 74, 74, 74, 75, 75, 75, 75, 75, 75, 75, 75, 75, 75, 75, 75, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 76, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 77, 78, 78, 78, 78, 78, 78, 78, 78, 78, 78, 78, 78, 79, 79, 79, 79, 79, 79, 79, 79, 79, 79, 79, 79, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 81, 81, 81, 81, 81, 81, 81, 81, 81, 81, 81, 81, 82, 82, 82, 82, 82, 82, 82, 82, 82, 82, 82, 82, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 83, 84, 84, 84, 84, 84, 84, 84, 84, 84, 84, 84, 84, 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 85, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 86, 87, 87, 87, 87, 87, 87, 87, 87, 87, 87, 87, 87, 88, 88, 88, 88, 88, 88, 88, 88, 88, 88, 88, 88, 89, 89, 89, 89, 89, 89, 89, 89, 89, 89, 89, 89, 90 };
    }
}
;


