using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace onemap.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "OneMap");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,")
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "City",
                schema: "OneMap",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    name = table.Column<string>(maxLength: 200, nullable: false),
                    point = table.Column<Point>(type: "geography (point)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.id);
                });

            migrationBuilder.InsertData(
                schema: "OneMap",
                table: "City",
                columns: new[] { "id", "name", "point" },
                values: new object[,]
                {
                    { new Guid("94de57a8-75f4-482b-90b2-53f31f39788d"), "ADANA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37 35.321333)") },
                    { new Guid("206156cd-9a6c-46f4-b9a8-d442202c6da5"), "MERSİN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (36.8 34.633333)") },
                    { new Guid("ecc7aec9-7d19-4a0a-9ef9-1472dee41dbf"), "MARDİN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.321163 40.724477)") },
                    { new Guid("402776e4-b975-4437-9bfc-b03dbf977e59"), "MANİSA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.619099 27.428921)") },
                    { new Guid("b8d34500-b30e-46b1-b5ac-1305212759c6"), "MALATYA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.35519 38.30946)") },
                    { new Guid("f6452fa6-610b-42bd-984b-c61e94262801"), "KÜTAHYA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.416667 29.983333)") },
                    { new Guid("79329f4f-e756-4445-b6a5-ac84e720ff07"), "KONYA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.866667 32.483333)") },
                    { new Guid("bc7e88b9-efaf-4595-a377-80fb0c6ed1c0"), "KOCAELİ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.85327 29.88152)") },
                    { new Guid("58c94d69-b4c2-4913-8254-54c3637f3f51"), "MUĞLA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.215278 28.363611)") },
                    { new Guid("fc06188e-ed0f-4a84-bc21-6c326d754ee0"), "KİLİS", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (36.718399 37.12122)") },
                    { new Guid("a5e6d89d-c755-4e1c-908b-12d083abf07e"), "KIRKLARELİ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.733333 27.216667)") },
                    { new Guid("c7562fed-37fb-4f78-9156-4c164cb0ce2c"), "KIRIKKALE", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.846821 33.515251)") },
                    { new Guid("7a30247b-fda1-4a80-9e3b-a7c457e33b79"), "KAYSERİ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.73122 35.478729)") },
                    { new Guid("86273806-a55a-472b-9a7c-d34d025b05af"), "KASTAMONU", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.38871 33.78273)") },
                    { new Guid("ac4ccb7e-97ac-458f-b982-5a119eb4f112"), "KARS", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.616667 43.1)") },
                    { new Guid("b192ddb9-52f2-4ddb-ae08-c7879a0a5efc"), "KARAMAN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.17593 33.228748)") },
                    { new Guid("c48a1d4a-80eb-47ca-9fd0-486c4a469405"), "KARABÜK", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.2061 32.62035)") },
                    { new Guid("b6547907-5238-4bca-949d-482671cfed71"), "KIRŞEHİR", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.14249 34.17091)") },
                    { new Guid("aa66f936-a8c2-4d83-89e9-efe77b85132a"), "MUŞ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.946189 41.753893)") },
                    { new Guid("c1c10fbe-b4f7-463c-8507-6761768a3898"), "NEVŞEHİR", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.69394 34.685651)") },
                    { new Guid("3b56ccbd-7593-4bc1-9b91-3731f5a47b1d"), "NİĞDE", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.966667 34.683333)") },
                    { new Guid("d6d9ac3c-42f0-41ff-92a2-6fd9ee3bddfb"), "YALOVA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.65 29.266667)") },
                    { new Guid("e9ac521e-2073-4d21-9c45-a52199a78198"), "VAN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.48914 43.40889)") },
                    { new Guid("03d488a9-8242-43e4-be78-30202edb5ea0"), "UŞAK", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.682301 29.40819)") },
                    { new Guid("d25798e3-6f5c-4e78-99aa-daeb82cc3f85"), "TUNCELİ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.307355 39.438778)") },
                    { new Guid("018bd507-f2e3-4d48-938c-19cf4b09a57e"), "TRABZON", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.00145 39.7178)") },
                    { new Guid("5489f994-c4fe-4a28-8008-64632fc5af00"), "TOKAT", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.316667 36.55)") },
                    { new Guid("b57b849e-4026-4513-8da7-7ce590c3572f"), "TEKİRDAĞ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.983333 27.516667)") },
                    { new Guid("2870e83f-6f93-4d46-abae-84b5b86f698f"), "ŞIRNAK", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.418748 42.491834)") },
                    { new Guid("254753d4-4ca4-4797-b711-2206dc0564c9"), "ŞANLIURFA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.159149 38.796909)") },
                    { new Guid("5b697fba-49b6-4733-bdf8-67fd6bd23d3c"), "SİVAS", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.747662 37.017879)") },
                    { new Guid("95f80563-438c-4756-968a-a5c5cfab5399"), "SİNOP", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (42.02314 35.153069)") },
                    { new Guid("2964243e-4f5d-4552-b1b0-2d05e2d90298"), "SİİRT", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.933333 41.95)") },
                    { new Guid("741c3b66-d821-41f2-a18f-d2e2502f1f6e"), "SAMSUN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.292782 36.33128)") },
                    { new Guid("71b92e85-7612-4f15-98f1-f79ddb43bde5"), "SAKARYA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.693997 30.435763)") },
                    { new Guid("40fa97c6-862f-4153-be63-f0e0c02231b9"), "RİZE", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.02005 40.523449)") },
                    { new Guid("87dbbd64-f0df-4d99-8aa3-1640fd56dd5e"), "OSMANİYE", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.213026 36.176261)") },
                    { new Guid("b07ff5a1-2cbd-4834-b5e8-ce2e07ed70f0"), "ORDU", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.983879 37.876411)") },
                    { new Guid("fe521bf0-2a5d-4f26-9ddc-32f00e45c790"), "KAHRAMANMARAŞ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.585831 36.937149)") },
                    { new Guid("2779c734-79f3-43b5-bc92-8066c515f65e"), "YOZGAT", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.818081 34.81469)") },
                    { new Guid("debc4fd8-f168-4629-acc9-ca18ca90165e"), "İZMİR", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.41885 27.12872)") },
                    { new Guid("e1f2ffa3-b7de-4340-b855-6a7002ade3b2"), "ISPARTA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.764771 30.556561)") },
                    { new Guid("e075ca20-a245-4670-920b-b3e1322e1acf"), "BİNGÖL", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.062635 40.76961)") },
                    { new Guid("35d53af9-52ff-4b0e-9933-08f195fb249d"), "BİLECİK", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.056656 30.066524)") },
                    { new Guid("60da8e50-88ae-4bbc-b2cc-399e591b6a36"), "BAYBURT", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.255169 40.22488)") },
                    { new Guid("63acc3df-a931-40dd-8384-969bd87412ca"), "BATMAN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.881168 41.13509)") },
                    { new Guid("488a5538-d157-4c0c-9958-3833802a3ada"), "BARTIN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.581051 32.460979)") },
                    { new Guid("0f0b8548-597b-4991-ab27-4d42afdf22af"), "BALIKESİR", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.648369 27.88261)") },
                    { new Guid("370169b0-2131-4531-aa1d-3e1efd3d129a"), "AYDIN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.856041 27.841631)") },
                    { new Guid("474cb218-4f03-44ca-b653-6765e80e57a9"), "BİTLİS", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.393799 42.12318)") },
                    { new Guid("ef2b016a-f617-4271-bf4b-0579d479c51e"), "ARTVİN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.18277 41.818292)") },
                    { new Guid("e2cf897b-bb80-4250-bf13-01485e0478db"), "ANTALYA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (36.88414 30.70563)") },
                    { new Guid("632109e6-42d8-45bd-945f-7181d6617f17"), "ANKARA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.92077 32.85411)") },
                    { new Guid("a3f8b2a9-6a4b-4d5c-8631-ec7f5477ed3b"), "AMASYA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.64991 35.83532)") },
                    { new Guid("3c06d2df-74c3-44cf-844e-275f9a5792b0"), "AKSARAY", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.36869 34.03698)") },
                    { new Guid("6011dd67-6029-4fbc-bae5-3a32e19a3f0f"), "AĞRI", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.626922 43.021596)") },
                    { new Guid("380838be-e870-4952-8348-d095a5d00541"), "AFYONKARAHİSAR", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.750714 30.556692)") },
                    { new Guid("803dd307-e9f4-4aa1-95e6-fabed46e2a12"), "ADIYAMAN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.764751 38.278561)") },
                    { new Guid("48dcd7af-0543-47f3-b8e7-221112262b33"), "ARDAHAN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.110481 42.702171)") },
                    { new Guid("4cd02281-3df0-4a47-964d-3a0c3b47a596"), "BOLU", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.575977 31.578809)") },
                    { new Guid("7269da7f-1e9c-4fec-860b-e1c5523d8af2"), "BURDUR", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.461267 30.066524)") },
                    { new Guid("6e734069-963e-4668-9588-f12e19289989"), "BURSA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.266864 29.063448)") },
                    { new Guid("23462df0-a99a-474e-845e-2712e9fd3e96"), "IĞDIR", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.887984 44.004836)") },
                    { new Guid("45b9f946-9426-47ff-ac02-3b9f09c99c70"), "HATAY", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (36.401849 36.34981)") },
                    { new Guid("8dc1bc33-c903-4c86-8a20-bb1acd76cd62"), "HAKKARİ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.583333 43.733333)") },
                    { new Guid("96dd5ff3-9281-418b-86d5-96bfef768243"), "GÜMÜŞHANE", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.438588 39.508556)") },
                    { new Guid("a06973b9-e40b-47a2-9b58-f075b6367af1"), "GİRESUN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.912811 38.38953)") },
                    { new Guid("4da11cd4-af28-4ab8-9316-e3b3d72c52a8"), "GAZİANTEP", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.06622 37.38332)") },
                    { new Guid("9409c531-ae7c-4075-abd3-328262ad6e5e"), "ESKİŞEHİR", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.776667 30.520556)") },
                    { new Guid("68baeb03-78b2-48f3-b198-2b1acc33139c"), "ERZURUM", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.9 41.27)") },
                    { new Guid("96309364-8fc7-4bcd-bd65-7810e39c5696"), "ERZİNCAN", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (39.75 39.5)") },
                    { new Guid("865f77a5-c1f7-4502-bd59-825eb35f28c3"), "ELAZIĞ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (38.680969 39.226398)") },
                    { new Guid("070b819a-615f-4952-9299-6129ed83bc80"), "EDİRNE", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.681808 26.562269)") },
                    { new Guid("6a8e2b3b-dbe4-40d8-b9a6-01102aea2a7b"), "DÜZCE", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.843849 31.15654)") },
                    { new Guid("16f6d1c0-b8b8-42da-92b8-71450a107540"), "DİYARBAKIR", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.91441 40.230629)") },
                    { new Guid("3767a58f-2798-4564-997b-9c68d6bd1ac6"), "DENİZLİ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.77652 29.08639)") },
                    { new Guid("0113b149-4dd7-4ad5-890d-0615e10060db"), "ÇORUM", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.550556 34.955556)") },
                    { new Guid("e5d3ace1-8e06-4840-8a48-873fdc6a0db9"), "ÇANKIRI", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.601343 33.613421)") },
                    { new Guid("0cab341e-f674-4570-91aa-7b76b3ad33cf"), "ÇANAKKALE", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (40.155312 26.41416)") },
                    { new Guid("3eee232e-79af-4976-af2e-f5ff0d4cc96f"), "İSTANBUL", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.00527 28.97696)") },
                    { new Guid("fa811195-aafe-4927-a750-765f3bd5e296"), "ZONGULDAK", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (41.456409 31.798731)") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City",
                schema: "OneMap");
        }
    }
}
