﻿ALTER TABLE [dbo].[ReferenceItems] ADD [FriendlyId] [nvarchar](max)
ALTER TABLE [dbo].[ReferenceLists] ADD [FriendlyId] [nvarchar](max)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201712280840351_UpgradeDomainBase', N'DataReferencesDbContext',  0x1F8B0800000000000400ED5A496FE33614BE17E87F10746A8B8CE4642ED3C09E41C6890746B3214E06BD0D6889768852A446A4021B457F590FFD49FD0B7DD42E6AB1E4256D31BE1836978FEF3D3EBED57FFFF9D7F0C3CAA3C60B0E04E16C649E5A03D3C0CCE12E61CB9119CAC59B77E687F7DF7F37BC72BD95F1395DF756AD839D4C8CCC6729FD73DB16CE33F690B03CE2045CF085B41CEED9C8E5F6D960F0B37D7A6A63803001CB30860F2193C4C3D10FF839E6CCC1BE0C11BDE12EA62219879959846ADC220F0B1F3978647E726FB1B42E91440F78810320160BEB6A621A179420206786E9C23410635C2209C49E3F093C930167CB990F03883EAE7D0CEB16880A9C30719E2FEFCACFE04CF163E71B53282714927B3D014FDF2602B2F5ED5B89D9CC040822BC0251CBB5E23A12E3C8CCE43695D8330DFDC4F3310DD4EA06515FC25AC2AC6B22A455423A315AD69F64BA736A9D59036B70628C432AC3008F180E6580E889711FCE29717EC1EB47FE1B662316525A64045881B9D2000CDD07DCC7815CC389097B53D734ECF23E5BDF986D2BEC49780E097CBF85B3D19CE24C4DECD6ED9F110D718A00CA068FC7346ED0EA1AB3A57C1E99F0D534266485DD7424817D6204DE1A6C9241B8F19431AC3CF821EAF3E087DC734162E58E0F9A32F9F6ACB7D4AF9190602FC88260F742A658A07EF89178BD767F5C1F9CE5A9B8784124622F3DEB23E71423D69BEF19BCD3C3DF51748A12D2F819B1E536121E071856D66EECC9F1242098B9749D3FD3C33DB298E857D0885BBEF75B1CDAB9B1EFE6029419DF8F0B50BFBE61177083185AE27D3CEFA3993F9AF9A3993F9AF9D6436ED10B5946B65A574088C485693C601ACD8A67E2C73951D9527F49D64D02EE3D70AABB8478FACB8C8781A3A8E7CD6B1E51B0C4B29B1FBA10823B2422ACCE1125449539BD62AED181C258BE153E41D6E063880F5E05E8199903CB3AAD08B3FD8894C1BA23E20CAA7CC44FBA2C0A5C579D32A4BE129C230E1281945DE7E55CCDE3559D8F86BC3671D32251129D2B853FC3B2AC19F9CDD43353914D194509A6152596BA865210410E55AB9085952D7AAB8700DD9424E32563C3EE0794AA420128215B8F36CA0CD73C8DECDEF35A871D173BD2A288DD501519DE20DF073352A8922423C62C2E918CDFCCFA970DBC18C376444DF520A3363B49F200E21D6D360E5E26241052E9F11C29433676BDCAB2262D6FD0BDF4D4A222576F2ED5C874B5FA1EEF68A81969AAAF21E6729D00AB1E6632E21A172E7FC3FEA87E85280A6A42CD31A7A1C79AC2D5B6DD49B1A108900C75C78863CC22443CD21D210E208B08F14877843C3A2CA2E4A3DD91F408B188A7CF6D87AAE284265435D71DB514209694A038D11D2F89128B48C9504F0C2D06AC006AF33D742D8F0F4B0A970F77C72A468845B0E2786FCAF4CB2D0CF7780F5CBF8678A48A30B435B3A25B32BB62CA34E7A2DBC54E5633F6787BB59A91ABDFC16AD6EF3F8CD52CE6E74594E2F8D17E1EEDE7D17E7EEBF6B31CBA978D686DCAD2D362A6DB7A05932A31D124D692E95465D6C9A26A8835BAA06497D1B11D89490EB52589BD8982CCC28D0CA23115AA1C95D557FA30AEE77355BDA9A475FA924C6BB3F44E4BE386494AB5B9035EC9B1E225A601327821AECAAF666B01C28E34D19A7DA5630ACF5BE60BC0E991051632AEB29B9002BED3FAE7FF9D5EB62D844BFB34B45FBD5F1032F235C42057A00B1C5AB05BFB98BDA0C07946C10F1E5AFD5884EADB22DE09A8D81FD80948EF0110A5877BE900B8E064A45666EE42517D476027266BAAFE73D29FCF52C57F27829AABFADB4AAD52E5AF03DAB2CABF9BCAEB95FCDDF49EEFE906AA2EA5C958540ABB53E6E2D5C8FC3D423A37A6BF7ED1C14E8CBB00CCF8B93130FE68276CCB8EF0FFCF8656FBAFDBBCC0A3FD3CDACFA3FD7C7DFBF90A0DC3FDF708E37ED9966D41804C96ABFFA442DA20640089432599BD0F0873888F682D4FD52CAA8B6156F2CE70F5994BEC837AA9BA5D1DBB5D0EEC924666A7681E63934C7A7653ABEDA8F6EEA676839B7AA571E2056F79CE411162E52E2DA976061B4F8C3571535FB5F5C4DAA6E6BFD57B2D75495BBBC36DAFABB13E72908E6B3505078D2CFC551D1E8720CB1C42551718764ABA98AD99B2054F1F874651BA448F61B044E016D04500411072244C3B5888E82F23518E3832AFBC3976A7EC2E947E288165ECCD69A9CEA69E56DBF9515BB94CF3F0CE8FFE2AB20F16804CA23CDB1DFB1812EA66744FAA9EAD0942BDD94F18C6E3BB041320F1729D21DD72D61128115F666A1EB1E7530013776C865EF036B43D097C8D97C859A795946690CD175116FBF092A065803C9160E4FBE127E8B0EBADDEFF03A3CE6F32B1310000 , N'6.2.0-61023')
