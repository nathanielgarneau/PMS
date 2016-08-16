﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using PMS.DAL.Interfaces;
using PMS.Xam.Model.Interfaces;

namespace PMS.DAL.Seeds
{
    public class City : ISeed
    {
        public void Seed(CodeFirstModel context)
        {
            context.City.AddOrUpdate(
                x => x.Id,
                GetCities(context)
                );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        private PMS.Xam.DAL.Model.City[] GetCities(CodeFirstModel context)
        {
            var cities = new List<PMS.Xam.DAL.Model.City>();
            foreach (var kvp in CanadianCities)
            {
                var city = new PMS.Xam.DAL.Model.City()
                {
                    Name = kvp.Key,
                    Province = context.Province.First(x => x.Name == kvp.Value)
                };
                cities.Add(city);
            }

            return cities.ToArray();
        }


        private readonly Dictionary<string, string> CanadianCities = new Dictionary<string, string>()
        {
            {
                "100 Mile House", "British Columbia"
            },
            {
                "108 Mile House", "British Columbia"
            },
            {
                "108 Mile Ranch", "British Columbia"
            },
            {
                "150 Mile House", "British Columbia"
            },
            {
                "Abbey", "Saskatchewan"
            },
            {
                "Abbotsford", "British Columbia"
            },
            {
                "Aberarder", "Ontario"
            },
            {
                "Abercorn", "Quebec"
            },
            {
                "Aberdeen", "Saskatchewan"
            },
            {
                "Abernethy", "Saskatchewan"
            },
            {
                "Abitibi Canyon", "Ontario"
            },
            {
                "Acadia Valley", "Alberta"
            },
            {
                "Acme", "Alberta"
            },
            {
                "Acton", "Ontario"
            },
            {
                "Acton Vale", "Quebec"
            },
            {
                "Adamsville", "Quebec"
            },
            {
                "Adolphustown", "Ontario"
            },
            {
                "Advocate Harbour", "Nova Scotia"
            },
            {
                "Agassiz", "British Columbia"
            },
            {
                "Agassiz Provincial Forest", "Manitoba"
            },
            {
                "Aguanish", "Quebec"
            },
            {
                "Ahousat", "British Columbia"
            },
            {
                "Ailsa Craig", "Ontario"
            },
            {
                "Airdrie", "Alberta"
            },
            {
                "Ajax", "Ontario"
            },
            {
                "Aklavik", "Northwest Territories"
            },
            {
                "Alameda", "Saskatchewan"
            },
            {
                "Alban", "Ontario"
            },
            {
                "Albanel", "Quebec"
            },
            {
                "Albert", "New Brunswick"
            },
            {
                "Albert Mines", "New Brunswick"
            },
            {
                "Alberta Beach", "Alberta"
            },
            {
                "Alberton", "Prince Edward Island"
            },
            {
                "Alder Flats", "Alberta"
            },
            {
                "Aldergrove", "British Columbia"
            },
            {
                "Alderville First Nation", "Ontario"
            },
            {
                "Alert Bay", "British Columbia"
            },
            {
                "Alexander", "Manitoba"
            },
            {
                "Alexandria", "Ontario"
            },
            {
                "Alexis Creek", "British Columbia"
            },
            {
                "Alfred", "Ontario"
            },
            {
                "Algoma Mills", "Ontario"
            },
            {
                "Alida", "Saskatchewan"
            },
            {
                "Alix", "Alberta"
            },
            {
                "Alkali Lake", "British Columbia"
            },
            {
                "Allan", "Saskatchewan"
            },
            {
                "Allardville", "New Brunswick"
            },
            {
                "Alliance", "Alberta"
            },
            {
                "Alliston", "Ontario"
            },
            {
                "Alma", "New Brunswick"
            },
            {
                "Alma", "Quebec"
            },
            {
                "Almonte", "Ontario"
            },
            {
                "Alonsa", "Manitoba"
            },
            {
                "Alouette", "Quebec"
            },
            {
                "Alsask", "Saskatchewan"
            },
            {
                "Altario", "Alberta"
            },
            {
                "Altona", "Manitoba"
            },
            {
                "Alvena", "Saskatchewan"
            },
            {
                "Alvinston", "Ontario"
            },
            {
                "Amherst", "Nova Scotia"
            },
            {
                "Amherstburg", "Ontario"
            },
            {
                "Amos", "Quebec"
            },
            {
                "Amqui", "Quebec"
            },
            {
                "Ancaster", "Ontario"
            },
            {
                "Andrew", "Alberta"
            },
            {
                "Aneroid", "Saskatchewan"
            },
            {
                "Angliers", "Quebec"
            },
            {
                "Angus", "Ontario"
            },
            {
                "Anjou", "Quebec"
            },
            {
                "Annapolis Royal", "Nova Scotia"
            },
            {
                "Anse-Saint-Jean", "Quebec"
            },
            {
                "Antigonish", "Nova Scotia"
            },
            {
                "Anzac", "Alberta"
            },
            {
                "Appleton", "Newfoundland"
            },
            {
                "Apsley", "Ontario"
            },
            {
                "Arborfield", "Saskatchewan"
            },
            {
                "Arborg", "Manitoba"
            },
            {
                "Archerwill", "Saskatchewan"
            },
            {
                "Arcola", "Saskatchewan"
            },
            {
                "Arden", "Ontario"
            },
            {
                "Ardrossan", "Alberta"
            },
            {
                "Argentia", "Newfoundland"
            },
            {
                "Argyle", "Nova Scotia"
            },
            {
                "Arichat", "Nova Scotia"
            },
            {
                "Arkell", "Ontario"
            },
            {
                "Arkona", "Ontario"
            },
            {
                "Armagh", "Quebec"
            },
            {
                "Armstrong", "British Columbia"
            },
            {
                "Armstrong", "Ontario"
            },
            {
                "Arnold`s Cove", "Newfoundland"
            },
            {
                "Arnprior", "Ontario"
            },
            {
                "Arrowwood", "Alberta"
            },
            {
                "Arthur", "Ontario"
            },
            {
                "Arundel", "Quebec"
            },
            {
                "Arviat", "Nunavut"
            },
            {
                "Asbestos", "Quebec"
            },
            {
                "Ascot", "Quebec"
            },
            {
                "Ascot Corner", "Quebec"
            },
            {
                "Ashcroft", "British Columbia"
            },
            {
                "Ashern", "Manitoba"
            },
            {
                "Ashmont", "Alberta"
            },
            {
                "Ashuapmushuan", "Quebec"
            },
            {
                "Asquith", "Saskatchewan"
            },
            {
                "Assiniboia", "Saskatchewan"
            },
            {
                "Assumption", "Alberta"
            },
            {
                "Aston-Jonction", "Quebec"
            },
            {
                "Athabasca", "Alberta"
            },
            {
                "Athens", "Ontario"
            },
            {
                "Atikokan", "Ontario"
            },
            {
                "Atlin", "British Columbia"
            },
            {
                "Attawapiskat", "Ontario"
            },
            {
                "Atwood", "Ontario"
            },
            {
                "Auburn", "Ontario"
            },
            {
                "Aurora", "Ontario"
            },
            {
                "Austin", "Manitoba"
            },
            {
                "Avola", "British Columbia"
            },
            {
                "Avondale", "Newfoundland"
            },
            {
                "Avonlea", "Saskatchewan"
            },
            {
                "Avonmore", "Ontario"
            },
            {
                "Ayer`s Cliff", "Quebec"
            },
            {
                "Aylesford", "Nova Scotia"
            },
            {
                "Aylmer", "Ontario"
            },
            {
                "Aylmer", "Quebec"
            },
            {
                "Ayr", "Ontario"
            },
            {
                "Ayton", "Ontario"
            },
            {
                "Azilda", "Ontario"
            },
            {
                "Baddeck", "Nova Scotia"
            },
            {
                "Baden", "Ontario"
            },
            {
                "Badger", "Newfoundland"
            },
            {
                "Bagotville", "Quebec"
            },
            {
                "Baie Verte", "Newfoundland"
            },
            {
                "Baie-Comeau", "Quebec"
            },
            {
                "Baie-de-Shawinigan", "Quebec"
            },
            {
                "Baie-des-Sables", "Quebec"
            },
            {
                "Baie-du-Febvre", "Quebec"
            },
            {
                "Baie-d`Urfe", "Quebec"
            },
            {
                "Baie-Johan-Beetz", "Quebec"
            },
            {
                "Baie-Sainte-Catherine", "Quebec"
            },
            {
                "Baie-St-Paul", "Quebec"
            },
            {
                "Baie-Ste-Anne", "New Brunswick"
            },
            {
                "Baie-Trinite", "Quebec"
            },
            {
                "Bailieboro", "Ontario"
            },
            {
                "Baker Brook", "New Brunswick"
            },
            {
                "Baker Lake", "Nunavut"
            },
            {
                "Bala", "Ontario"
            },
            {
                "Balcarres", "Saskatchewan"
            },
            {
                "Baldur", "Manitoba"
            },
            {
                "Balfour", "British Columbia"
            },
            {
                "Balgonie", "Saskatchewan"
            },
            {
                "Balmertown", "Ontario"
            },
            {
                "Balmoral", "New Brunswick"
            },
            {
                "Baltimore", "Ontario"
            },
            {
                "Bamfield", "British Columbia"
            },
            {
                "Bancroft", "Ontario"
            },
            {
                "Banff", "Alberta"
            },
            {
                "Barachois", "Quebec"
            },
            {
                "Barkmere", "Quebec"
            },
            {
                "Barons", "Alberta"
            },
            {
                "Barraute", "Quebec"
            },
            {
                "Barrhead", "Alberta"
            },
            {
                "Barrie", "Ontario"
            },
            {
                "Barriere", "British Columbia"
            },
            {
                "Barry`s Bay", "Ontario"
            },
            {
                "Barwick", "Ontario"
            },
            {
                "Bashaw", "Alberta"
            },
            {
                "Bass River", "Nova Scotia"
            },
            {
                "Bassano", "Alberta"
            },
            {
                "Basswood", "Manitoba"
            },
            {
                "Batawa", "Ontario"
            },
            {
                "Batchawana Bay", "Ontario"
            },
            {
                "Bath", "New Brunswick"
            },
            {
                "Bath", "Ontario"
            },
            {
                "Bathurst", "New Brunswick"
            },
            {
                "Batiscan", "Quebec"
            },
            {
                "Batteau", "Newfoundland"
            },
            {
                "Battle Harbour", "Newfoundland"
            },
            {
                "Battleford", "Saskatchewan"
            },
            {
                "Bauline", "Newfoundland"
            },
            {
                "Bawlf", "Alberta"
            },
            {
                "Bay Bulls", "Newfoundland"
            },
            {
                "Bay de Verde", "Newfoundland"
            },
            {
                "Bay L`Argent", "Newfoundland"
            },
            {
                "Bay Roberts", "Newfoundland"
            },
            {
                "Bayfield", "Ontario"
            },
            {
                "Baysville", "Ontario"
            },
            {
                "Beach Grove", "British Columbia"
            },
            {
                "Beachburg", "Ontario"
            },
            {
                "Beachville", "Ontario"
            },
            {
                "Beaconsfield", "Quebec"
            },
            {
                "Beamsville", "Ontario"
            },
            {
                "Bear Canyon", "Alberta"
            },
            {
                "Bear Lake", "British Columbia"
            },
            {
                "Bear River", "Nova Scotia"
            },
            {
                "Beardmore", "Ontario"
            },
            {
                "Bearskin Lake", "Ontario"
            },
            {
                "Bearskin Lake First Nation", "Ontario"
            },
            {
                "Bear`s Passage", "Ontario"
            },
            {
                "Beaucanton", "Quebec"
            },
            {
                "Beauceville", "Quebec"
            },
            {
                "Beauharnois", "Quebec"
            },
            {
                "Beaulac-Garthby", "Quebec"
            },
            {
                "Beaumont", "Alberta"
            },
            {
                "Beaumont", "Newfoundland"
            },
            {
                "Beaumont", "Quebec"
            },
            {
                "Beauport", "Quebec"
            },
            {
                "Beaupre", "Quebec"
            },
            {
                "Beausejour", "Manitoba"
            },
            {
                "Beauval", "Saskatchewan"
            },
            {
                "Beaver Cove", "British Columbia"
            },
            {
                "Beaver Creek", "Yukon"
            },
            {
                "Beaverdell", "British Columbia"
            },
            {
                "Beaverlodge", "Alberta"
            },
            {
                "Beaverton", "Ontario"
            },
            {
                "Becancour", "Quebec"
            },
            {
                "Bedeque", "Prince Edward Island"
            },
            {
                "Bedford", "Quebec"
            },
            {
                "Beechy", "Saskatchewan"
            },
            {
                "Beeton", "Ontario"
            },
            {
                "Beiseker", "Alberta"
            },
            {
                "Bell Island", "Newfoundland"
            },
            {
                "Bella Bella", "British Columbia"
            },
            {
                "Bella Coola", "British Columbia"
            },
            {
                "Belle Neige", "Quebec"
            },
            {
                "Belle River", "Ontario"
            },
            {
                "Belledune", "New Brunswick"
            },
            {
                "Bellefeuille", "Quebec"
            },
            {
                "Belleoram", "Newfoundland"
            },
            {
                "Belleterre", "Quebec"
            },
            {
                "Belleville", "Ontario"
            },
            {
                "Bellevue", "Newfoundland"
            },
            {
                "Belmont", "Manitoba"
            },
            {
                "Belmont", "Ontario"
            },
            {
                "Beloeil", "Quebec"
            },
            {
                "Bengough", "Saskatchewan"
            },
            {
                "Benito", "Manitoba"
            },
            {
                "Benoit`s Cove", "Newfoundland"
            },
            {
                "Bentley", "Alberta"
            },
            {
                "Berens River", "Manitoba"
            },
            {
                "Beresford", "New Brunswick"
            },
            {
                "Bergeronnes", "Quebec"
            },
            {
                "Berthierville", "Quebec"
            },
            {
                "Berwick", "Nova Scotia"
            },
            {
                "Berwyn", "Alberta"
            },
            {
                "Bethany", "Ontario"
            },
            {
                "Bethesda", "Ontario"
            },
            {
                "Bethune", "Saskatchewan"
            },
            {
                "Betsiamites", "Quebec"
            },
            {
                "Beulah", "Manitoba"
            },
            {
                "Biencourt", "Quebec"
            },
            {
                "Bienfait", "Saskatchewan"
            },
            {
                "Big River", "Saskatchewan"
            },
            {
                "Big Trout Lake", "Ontario"
            },
            {
                "Big Valley", "Alberta"
            },
            {
                "Biggar", "Saskatchewan"
            },
            {
                "Binbrook", "Ontario"
            },
            {
                "Bindloss", "Alberta"
            },
            {
                "Binscarth", "Manitoba"
            },
            {
                "Birch Hills", "Saskatchewan"
            },
            {
                "Birch Island", "Ontario"
            },
            {
                "Birchy Bay", "Newfoundland"
            },
            {
                "Birsay", "Saskatchewan"
            },
            {
                "Birtle", "Manitoba"
            },
            {
                "Biscotasing", "Ontario"
            },
            {
                "Bishopton", "Quebec"
            },
            {
                "Bishop`s Falls", "Newfoundland"
            },
            {
                "Bissett", "Manitoba"
            },
            {
                "Black Creek", "British Columbia"
            },
            {
                "Black Diamond", "Alberta"
            },
            {
                "Black Duck Cove", "Newfoundland"
            },
            {
                "Black Lake", "Quebec"
            },
            {
                "Black Point", "British Columbia"
            },
            {
                "Black Tickle", "Newfoundland"
            },
            {
                "Blackfalds", "Alberta"
            },
            {
                "Blackie", "Alberta"
            },
            {
                "Blacks Harbour", "New Brunswick"
            },
            {
                "Blackstock", "Ontario"
            },
            {
                "Blackville", "New Brunswick"
            },
            {
                "Blaine Lake", "Saskatchewan"
            },
            {
                "Blainville", "Quebec"
            },
            {
                "Blanc-Sablon", "Quebec"
            },
            {
                "Blandford", "Nova Scotia"
            },
            {
                "Blenheim", "Ontario"
            },
            {
                "Blezard Valley", "Ontario"
            },
            {
                "Blind River", "Ontario"
            },
            {
                "Bloomfield", "Ontario"
            },
            {
                "Blue Ridge", "Alberta"
            },
            {
                "Blue River", "British Columbia"
            },
            {
                "Blyth", "Ontario"
            },
            {
                "Bob Quinn Lake", "British Columbia"
            },
            {
                "Bobcaygeon", "Ontario"
            },
            {
                "Boiestown", "New Brunswick"
            },
            {
                "Bois-des-Filion", "Quebec"
            },
            {
                "Boisbriand", "Quebec"
            },
            {
                "Boischatel", "Quebec"
            },
            {
                "Boisdale", "Nova Scotia"
            },
            {
                "Boissevain", "Manitoba"
            },
            {
                "Bolton", "Ontario"
            },
            {
                "Bon Accord", "Alberta"
            },
            {
                "Bonanza", "Alberta"
            },
            {
                "Bonaventure", "Quebec"
            },
            {
                "Bonavista", "Newfoundland"
            },
            {
                "Bonfield", "Ontario"
            },
            {
                "Bonne-Esperance", "Quebec"
            },
            {
                "Bonnyville", "Alberta"
            },
            {
                "Borden", "Ontario"
            },
            {
                "Borden", "Prince Edward Island"
            },
            {
                "Borden", "Saskatchewan"
            },
            {
                "Boston Bar", "British Columbia"
            },
            {
                "Boswell", "British Columbia"
            },
            {
                "Bothwell", "Ontario"
            },
            {
                "Botwood", "Newfoundland"
            },
            {
                "Boucherville", "Quebec"
            },
            {
                "Bouchette", "Quebec"
            },
            {
                "Bouctouche", "New Brunswick"
            },
            {
                "Boularderie", "Nova Scotia"
            },
            {
                "Bourget", "Ontario"
            },
            {
                "Bow Island", "Alberta"
            },
            {
                "Bowden", "Alberta"
            },
            {
                "Bowen Island", "British Columbia"
            },
            {
                "Bowmanville", "Ontario"
            },
            {
                "Bowser", "British Columbia"
            },
            {
                "Boyd`s Cove", "Newfoundland"
            },
            {
                "Boyle", "Alberta"
            },
            {
                "Bracebridge", "Ontario"
            },
            {
                "Bradford", "Ontario"
            },
            {
                "Bradford West Gwillimbury", "Ontario"
            },
            {
                "Braeside", "Ontario"
            },
            {
                "Bragg Creek", "Alberta"
            },
            {
                "Brampton", "Ontario"
            },
            {
                "Branch", "Newfoundland"
            },
            {
                "Brandon", "Manitoba"
            },
            {
                "Brantford", "Ontario"
            },
            {
                "Breakeyville", "Quebec"
            },
            {
                "Brechin", "Ontario"
            },
            {
                "Bredenbury", "Saskatchewan"
            },
            {
                "Brent`s Cove", "Newfoundland"
            },
            {
                "Breslau", "Ontario"
            },
            {
                "Breton", "Alberta"
            },
            {
                "Bridge Lake", "British Columbia"
            },
            {
                "Bridgenorth", "Ontario"
            },
            {
                "Bridgetown", "Nova Scotia"
            },
            {
                "Bridgewater", "Nova Scotia"
            },
            {
                "Briercrest", "Saskatchewan"
            },
            {
                "Brigden", "Ontario"
            },
            {
                "Brigham", "Quebec"
            },
            {
                "Bright", "Ontario"
            },
            {
                "Brighton", "Ontario"
            },
            {
                "Brights Grove", "Ontario"
            },
            {
                "Brigus", "Newfoundland"
            },
            {
                "Britannia Beach", "British Columbia"
            },
            {
                "Britt", "Ontario"
            },
            {
                "Broadview", "Saskatchewan"
            },
            {
                "Brochet", "Manitoba"
            },
            {
                "Brock", "Saskatchewan"
            },
            {
                "Brocket", "Alberta"
            },
            {
                "Brockville", "Ontario"
            },
            {
                "Brome", "Quebec"
            },
            {
                "Bromont", "Quebec"
            },
            {
                "Bromptonville", "Quebec"
            },
            {
                "Brookdale", "Manitoba"
            },
            {
                "Brookfield", "Nova Scotia"
            },
            {
                "Brooklin", "Ontario"
            },
            {
                "Brooks", "Alberta"
            },
            {
                "Brossard", "Quebec"
            },
            {
                "Browns Flat", "New Brunswick"
            },
            {
                "Brownsburg", "Quebec"
            },
            {
                "Brownsville", "Ontario"
            },
            {
                "Brownvale", "Alberta"
            },
            {
                "Bruce Mines", "Ontario"
            },
            {
                "Bruderheim", "Alberta"
            },
            {
                "Bruno", "Saskatchewan"
            },
            {
                "Brussels", "Ontario"
            },
            {
                "Bryson", "Quebec"
            },
            {
                "Buchanan", "Saskatchewan"
            },
            {
                "Buchans", "Newfoundland"
            },
            {
                "Buckhorn", "Ontario"
            },
            {
                "Buckingham", "Quebec"
            },
            {
                "Buffalo Narrows", "Saskatchewan"
            },
            {
                "Burdett", "Alberta"
            },
            {
                "Burford", "Ontario"
            },
            {
                "Burgeo", "Newfoundland"
            },
            {
                "Burgessville", "Ontario"
            },
            {
                "Burin", "Newfoundland"
            },
            {
                "Burk`s Falls", "Ontario"
            },
            {
                "Burleigh Falls", "Ontario"
            },
            {
                "Burlington", "Newfoundland"
            },
            {
                "Burlington", "Ontario"
            },
            {
                "Burnaby", "British Columbia"
            },
            {
                "Burns Lake", "British Columbia"
            },
            {
                "Burnt Islands", "Newfoundland"
            },
            {
                "Burstall", "Saskatchewan"
            },
            {
                "Burwash Landing", "Yukon"
            },
            {
                "Bury", "Quebec"
            },
            {
                "Byemoor", "Alberta"
            },
            {
                "Cabano", "Quebec"
            },
            {
                "Cabri", "Saskatchewan"
            },
            {
                "Cache Bay", "Ontario"
            },
            {
                "Cache Creek", "British Columbia"
            },
            {
                "Cacouna", "Quebec"
            },
            {
                "Cadillac", "Quebec"
            },
            {
                "Cadillac", "Saskatchewan"
            },
            {
                "Cadomin", "Alberta"
            },
            {
                "Calabogie", "Ontario"
            },
            {
                "Calder", "Saskatchewan"
            },
            {
                "Caledon", "Ontario"
            },
            {
                "Caledon East", "Ontario"
            },
            {
                "Caledonia", "Ontario"
            },
            {
                "Calgary", "Alberta"
            },
            {
                "Callander", "Ontario"
            },
            {
                "Calling Lake", "Alberta"
            },
            {
                "Calmar", "Alberta"
            },
            {
                "Calstock", "Ontario"
            },
            {
                "Calumet", "Quebec"
            },
            {
                "Cambray", "Ontario"
            },
            {
                "Cambridge", "Ontario"
            },
            {
                "Cambridge Bay", "Nunavut"
            },
            {
                "Cameron", "Ontario"
            },
            {
                "Camlachie", "Ontario"
            },
            {
                "Campbell River", "British Columbia"
            },
            {
                "Campbellford", "Ontario"
            },
            {
                "Campbellton", "New Brunswick"
            },
            {
                "Campbellton", "Newfoundland"
            },
            {
                "Campbellville", "Ontario"
            },
            {
                "Campbell`s Bay", "Quebec"
            },
            {
                "Camperville", "Manitoba"
            },
            {
                "Campobello Island", "New Brunswick"
            },
            {
                "Camrose", "Alberta"
            },
            {
                "Canal Flats", "British Columbia"
            },
            {
                "Candiac", "Quebec"
            },
            {
                "Canmore", "Alberta"
            },
            {
                "Canning", "Nova Scotia"
            },
            {
                "Cannington", "Ontario"
            },
            {
                "Canoe Narrows", "Saskatchewan"
            },
            {
                "Canora", "Saskatchewan"
            },
            {
                "Canso", "Nova Scotia"
            },
            {
                "Canterbury", "New Brunswick"
            },
            {
                "Cantley", "Quebec"
            },
            {
                "Canwood", "Saskatchewan"
            },
            {
                "Cap-a-l`Aigle", "Quebec"
            },
            {
                "Cap-aux-Meules", "Quebec"
            },
            {
                "Cap-Chat", "Quebec"
            },
            {
                "Cap-de-la-Madeleine", "Quebec"
            },
            {
                "Cap-des-Rosiers", "Quebec"
            },
            {
                "Cap-Pele", "New Brunswick"
            },
            {
                "Cap-Rouge", "Quebec"
            },
            {
                "Cap-Saint-Ignace", "Quebec"
            },
            {
                "Cape Broyle", "Newfoundland"
            },
            {
                "Cape Dorset", "Nunavut"
            },
            {
                "Caplan", "Quebec"
            },
            {
                "Capreol", "Ontario"
            },
            {
                "Caradoc First Nation", "Ontario"
            },
            {
                "Caramat", "Ontario"
            },
            {
                "Caraquet", "New Brunswick"
            },
            {
                "Carberry", "Manitoba"
            },
            {
                "Carbon", "Alberta"
            },
            {
                "Carbonear", "Newfoundland"
            },
            {
                "Carcross", "Yukon"
            },
            {
                "Cardiff", "Ontario"
            },
            {
                "Cardigan", "Prince Edward Island"
            },
            {
                "Cardinal", "Ontario"
            },
            {
                "Cardston", "Alberta"
            },
            {
                "Cargill", "Ontario"
            },
            {
                "Caribou", "Nova Scotia"
            },
            {
                "Carievale", "Saskatchewan"
            },
            {
                "Carignan", "Quebec"
            },
            {
                "Carillon", "Quebec"
            },
            {
                "Carleton", "Nova Scotia"
            },
            {
                "Carleton", "Quebec"
            },
            {
                "Carleton Place", "Ontario"
            },
            {
                "Carlyle", "Saskatchewan"
            },
            {
                "Carmacks", "Yukon"
            },
            {
                "Carman", "Manitoba"
            },
            {
                "Carmangay", "Alberta"
            },
            {
                "Carmanville", "Newfoundland"
            },
            {
                "Carnarvon", "Ontario"
            },
            {
                "Carnduff", "Saskatchewan"
            },
            {
                "Caroline", "Alberta"
            },
            {
                "Caron", "Saskatchewan"
            },
            {
                "Carp", "Ontario"
            },
            {
                "Carrot River", "Saskatchewan"
            },
            {
                "Carseland", "Alberta"
            },
            {
                "Carstairs", "Alberta"
            },
            {
                "Cartier", "Ontario"
            },
            {
                "Cartwright", "Manitoba"
            },
            {
                "Cartwright", "Newfoundland"
            },
            {
                "Casselman", "Ontario"
            },
            {
                "Cassiar", "British Columbia"
            },
            {
                "Castlegar", "British Columbia"
            },
            {
                "Castlemore", "Ontario"
            },
            {
                "Castleton", "Ontario"
            },
            {
                "Castor", "Alberta"
            },
            {
                "Cat Lake", "Ontario"
            },
            {
                "Catalina", "Newfoundland"
            },
            {
                "Causapscal", "Quebec"
            },
            {
                "Cavan", "Ontario"
            },
            {
                "Cayley", "Alberta"
            },
            {
                "Cayuga", "Ontario"
            },
            {
                "Celista", "British Columbia"
            },
            {
                "Central Butte", "Saskatchewan"
            },
            {
                "Centralia", "Ontario"
            },
            {
                "Centreville", "New Brunswick"
            },
            {
                "Centreville-Wareham-Trinity", "Newfoundland"
            },
            {
                "Cereal", "Alberta"
            },
            {
                "Cessford", "Alberta"
            },
            {
                "Ceylon", "Saskatchewan"
            },
            {
                "Chalk River", "Ontario"
            },
            {
                "Chambly", "Quebec"
            },
            {
                "Chambord", "Quebec"
            },
            {
                "Champion", "Alberta"
            },
            {
                "Champlain", "Quebec"
            },
            {
                "Chance Cove", "Newfoundland"
            },
            {
                "Chandler", "Quebec"
            },
            {
                "Change islands", "Newfoundland"
            },
            {
                "Chapais", "Quebec"
            },
            {
                "Chapeau", "Quebec"
            },
            {
                "Chapel Arm", "Newfoundland"
            },
            {
                "Chapleau", "Ontario"
            },
            {
                "Chaplin", "Saskatchewan"
            },
            {
                "Charette", "Quebec"
            },
            {
                "Charlemagne", "Quebec"
            },
            {
                "Charlesbourg", "Quebec"
            },
            {
                "Charlevoix", "Quebec"
            },
            {
                "Charlottetown", "Newfoundland"
            },
            {
                "Charlottetown", "Prince Edward Island"
            },
            {
                "Charlton", "Ontario"
            },
            {
                "Charny", "Quebec"
            },
            {
                "Chartierville", "Quebec"
            },
            {
                "Chase", "British Columbia"
            },
            {
                "Chateau-Richer", "Quebec"
            },
            {
                "Chateauguay", "Quebec"
            },
            {
                "Chatham", "New Brunswick"
            },
            {
                "Chatham", "Ontario"
            },
            {
                "Chatsworth", "Ontario"
            },
            {
                "Chauvin", "Alberta"
            },
            {
                "Chelmsford", "Ontario"
            },
            {
                "Chelsea", "Nova Scotia"
            },
            {
                "Chelsea", "Quebec"
            },
            {
                "Chemainus", "British Columbia"
            },
            {
                "Cheneville", "Quebec"
            },
            {
                "Chesley", "Ontario"
            },
            {
                "Chester", "Nova Scotia"
            },
            {
                "Chesterfield Inlet", "Nunavut"
            },
            {
                "Chestermere", "Alberta"
            },
            {
                "Chesterville", "Ontario"
            },
            {
                "Chesterville", "Quebec"
            },
            {
                "Cheticamp", "Nova Scotia"
            },
            {
                "Chetwynd", "British Columbia"
            },
            {
                "Cheverie", "Nova Scotia"
            },
            {
                "Chevery", "Quebec"
            },
            {
                "Chibougamau", "Quebec"
            },
            {
                "Chicoutimi", "Quebec"
            },
            {
                "Chiefs Point First Nation", "Ontario"
            },
            {
                "Chilliwack", "British Columbia"
            },
            {
                "Chipewyan Lake", "Alberta"
            },
            {
                "Chipman", "Alberta"
            },
            {
                "Chipman", "New Brunswick"
            },
            {
                "Chippewas of Kettle/Stony Poin", "Ontario"
            },
            {
                "Chippewas Of Sarnia First Nati", "Ontario"
            },
            {
                "Chisasibi", "Quebec"
            },
            {
                "Choiceland", "Saskatchewan"
            },
            {
                "Chomedey", "Quebec"
            },
            {
                "Christian Island", "Ontario"
            },
            {
                "Christina Lake", "British Columbia"
            },
            {
                "Christopher Lake", "Saskatchewan"
            },
            {
                "Churchbridge", "Saskatchewan"
            },
            {
                "Churchill", "Manitoba"
            },
            {
                "Churchill Falls", "Newfoundland"
            },
            {
                "Chute-aux-Outardes", "Quebec"
            },
            {
                "Chute-des-Passes", "Quebec"
            },
            {
                "Clair", "New Brunswick"
            },
            {
                "Clairmont", "Alberta"
            },
            {
                "Claremont", "Ontario"
            },
            {
                "Clarence Creek", "Ontario"
            },
            {
                "Clarence-Rockland", "Ontario"
            },
            {
                "Clarenville", "Newfoundland"
            },
            {
                "Clarenville-Shoal Harbour", "Newfoundland"
            },
            {
                "Claresholm", "Alberta"
            },
            {
                "Clarington", "Ontario"
            },
            {
                "Clarke`s Beach", "Newfoundland"
            },
            {
                "Clarks Corners", "New Brunswick"
            },
            {
                "Clarkson", "Ontario"
            },
            {
                "Clarksville", "Nova Scotia"
            },
            {
                "Clark`s Harbour", "Nova Scotia"
            },
            {
                "Clavet", "Saskatchewan"
            },
            {
                "Clearwater", "British Columbia"
            },
            {
                "Clearwater Bay", "Ontario"
            },
            {
                "Clericy", "Quebec"
            },
            {
                "Clermont", "Quebec"
            },
            {
                "Clifford", "Ontario"
            },
            {
                "Climax", "Saskatchewan"
            },
            {
                "Clinton", "British Columbia"
            },
            {
                "Clinton", "Ontario"
            },
            {
                "Clive", "Alberta"
            },
            {
                "Cloridorme", "Quebec"
            },
            {
                "Cloud Bay", "Ontario"
            },
            {
                "Clova", "Quebec"
            },
            {
                "Clyde", "Alberta"
            },
            {
                "Coaldale", "Alberta"
            },
            {
                "Coalhurst", "Alberta"
            },
            {
                "Coaticook", "Quebec"
            },
            {
                "Cobalt", "Ontario"
            },
            {
                "Cobble Hill", "British Columbia"
            },
            {
                "Cobden", "Ontario"
            },
            {
                "Coboconk", "Ontario"
            },
            {
                "Cobourg", "Ontario"
            },
            {
                "Cocagne", "New Brunswick"
            },
            {
                "Cochenour", "Ontario"
            },
            {
                "Cochin", "Saskatchewan"
            },
            {
                "Cochrane", "Alberta"
            },
            {
                "Cochrane", "Ontario"
            },
            {
                "Coderre", "Saskatchewan"
            },
            {
                "Codroy", "Newfoundland"
            },
            {
                "Coe Hill", "Ontario"
            },
            {
                "Colborne", "Ontario"
            },
            {
                "Colchester", "Ontario"
            },
            {
                "Cold Lake", "Alberta"
            },
            {
                "Cold Springs", "Ontario"
            },
            {
                "Coldwater", "Ontario"
            },
            {
                "Coleville", "Saskatchewan"
            },
            {
                "Colliers", "Newfoundland"
            },
            {
                "Collingwood", "Ontario"
            },
            {
                "Collingwood Corner", "Nova Scotia"
            },
            {
                "Colombier", "Quebec"
            },
            {
                "Colonsay", "Saskatchewan"
            },
            {
                "Colwood", "British Columbia"
            },
            {
                "Comber", "Ontario"
            },
            {
                "Come By Chance", "Newfoundland"
            },
            {
                "Comfort Cove-Newstead", "Newfoundland"
            },
            {
                "Comox", "British Columbia"
            },
            {
                "Compton", "Quebec"
            },
            {
                "Conception Bay South", "Newfoundland"
            },
            {
                "Conception Harbour", "Newfoundland"
            },
            {
                "Conche", "Newfoundland"
            },
            {
                "Concord", "Ontario"
            },
            {
                "Coniston", "Ontario"
            },
            {
                "Conklin", "Alberta"
            },
            {
                "Connaught", "Ontario"
            },
            {
                "Conne River", "Newfoundland"
            },
            {
                "Conquest", "Saskatchewan"
            },
            {
                "Consort", "Alberta"
            },
            {
                "Constance Bay", "Ontario"
            },
            {
                "Constance Lake First Nation", "Ontario"
            },
            {
                "Consul", "Saskatchewan"
            },
            {
                "Contrecoeur", "Quebec"
            },
            {
                "Cookshire", "Quebec"
            },
            {
                "Cookstown", "Ontario"
            },
            {
                "Cooksville", "Ontario"
            },
            {
                "Cook`s Harbour", "Newfoundland"
            },
            {
                "Coquitlam", "British Columbia"
            },
            {
                "Coral Harbour", "Nunavut"
            },
            {
                "Cormorant", "Manitoba"
            },
            {
                "Corner Brook", "Newfoundland"
            },
            {
                "Cornwall", "Ontario"
            },
            {
                "Cornwall", "Prince Edward Island"
            },
            {
                "Coronach", "Saskatchewan"
            },
            {
                "Coronation", "Alberta"
            },
            {
                "Corunna", "Ontario"
            },
            {
                "Cote-St-Luc", "Quebec"
            },
            {
                "Coteau-du-Lac", "Quebec"
            },
            {
                "Cottam", "Ontario"
            },
            {
                "Cottlesville", "Newfoundland"
            },
            {
                "Courcelette", "Quebec"
            },
            {
                "Courcelles", "Quebec"
            },
            {
                "Courtenay", "British Columbia"
            },
            {
                "Courtice", "Ontario"
            },
            {
                "Courtright", "Ontario"
            },
            {
                "Coutts", "Alberta"
            },
            {
                "Covehead", "Prince Edward Island"
            },
            {
                "Cow Head", "Newfoundland"
            },
            {
                "Cowan", "Manitoba"
            },
            {
                "Cowansville", "Quebec"
            },
            {
                "Cowichan Bay", "British Columbia"
            },
            {
                "Cowley", "Alberta"
            },
            {
                "Crabtree", "Quebec"
            },
            {
                "Craigmyle", "Alberta"
            },
            {
                "Craik", "Saskatchewan"
            },
            {
                "Cranberry Portage", "Manitoba"
            },
            {
                "Cranbrook", "British Columbia"
            },
            {
                "Crandall", "Manitoba"
            },
            {
                "Crapaud", "Prince Edward Island"
            },
            {
                "Crawford Bay", "British Columbia"
            },
            {
                "Crediton", "Ontario"
            },
            {
                "Creelman", "Saskatchewan"
            },
            {
                "Creemore", "Ontario"
            },
            {
                "Creighton", "Saskatchewan"
            },
            {
                "Cremona", "Alberta"
            },
            {
                "Crescent Beach", "British Columbia"
            },
            {
                "Creston", "British Columbia"
            },
            {
                "Cross Lake", "Manitoba"
            },
            {
                "Crossfield", "Alberta"
            },
            {
                "Crowsnest Pass", "Alberta"
            },
            {
                "Crysler", "Ontario"
            },
            {
                "Crystal Beach", "Ontario"
            },
            {
                "Crystal City", "Manitoba"
            },
            {
                "Cudworth", "Saskatchewan"
            },
            {
                "Cumberland", "British Columbia"
            },
            {
                "Cumberland", "Ontario"
            },
            {
                "Cumberland House", "Saskatchewan"
            },
            {
                "Cupar", "Saskatchewan"
            },
            {
                "Cupids", "Newfoundland"
            },
            {
                "Cut Knife", "Saskatchewan"
            },
            {
                "Cypress River", "Manitoba"
            },
            {
                "Czar", "Alberta"
            },
            {
                "Dalhousie", "New Brunswick"
            },
            {
                "Dalmeny", "Saskatchewan"
            },
            {
                "Daniel`s Harbour", "Newfoundland"
            },
            {
                "Danville", "Quebec"
            },
            {
                "Darlingford", "Manitoba"
            },
            {
                "Dartmouth", "Nova Scotia"
            },
            {
                "Dashwood", "Ontario"
            },
            {
                "Dauphin", "Manitoba"
            },
            {
                "Daveluyville", "Quebec"
            },
            {
                "Davidson", "Saskatchewan"
            },
            {
                "Davis Inlet", "Newfoundland"
            },
            {
                "Dawson", "Yukon"
            },
            {
                "Dawson Creek", "British Columbia"
            },
            {
                "Daysland", "Alberta"
            },
            {
                "Dease Lake", "British Columbia"
            },
            {
                "Deauville", "Quebec"
            },
            {
                "Debden", "Saskatchewan"
            },
            {
                "Debec", "New Brunswick"
            },
            {
                "Debert", "Nova Scotia"
            },
            {
                "DeBolt", "Alberta"
            },
            {
                "Deep River", "Ontario"
            },
            {
                "Deer Lake", "Newfoundland"
            },
            {
                "Deer Lake", "Ontario"
            },
            {
                "Deerbrook", "Ontario"
            },
            {
                "Degelis", "Quebec"
            },
            {
                "Delaware of the Thames(Moravia", "Ontario"
            },
            {
                "Delburne", "Alberta"
            },
            {
                "Delhi", "Ontario"
            },
            {
                "Delia", "Alberta"
            },
            {
                "Delisle", "Quebec"
            },
            {
                "Delisle", "Saskatchewan"
            },
            {
                "Deloraine", "Manitoba"
            },
            {
                "Delson", "Quebec"
            },
            {
                "Delta", "British Columbia"
            },
            {
                "Delta", "Ontario"
            },
            {
                "Denbigh", "Ontario"
            },
            {
                "Denzil", "Saskatchewan"
            },
            {
                "Derwent", "Alberta"
            },
            {
                "Desbarats", "Ontario"
            },
            {
                "Desbiens", "Quebec"
            },
            {
                "Deschaillons-sur-Saint-Laurent", "Quebec"
            },
            {
                "Deseronto", "Ontario"
            },
            {
                "Destruction Bay", "Yukon"
            },
            {
                "Deux-Montagnes", "Quebec"
            },
            {
                "Deux-Rivieres", "Ontario"
            },
            {
                "Devlin", "Ontario"
            },
            {
                "Devon", "Alberta"
            },
            {
                "Dewberry", "Alberta"
            },
            {
                "Didsbury", "Alberta"
            },
            {
                "Dieppe", "New Brunswick"
            },
            {
                "Digby", "Nova Scotia"
            },
            {
                "Dillon", "Saskatchewan"
            },
            {
                "Dingwall", "Nova Scotia"
            },
            {
                "Dinsmore", "Saskatchewan"
            },
            {
                "Disraeli", "Quebec"
            },
            {
                "Dixonville", "Alberta"
            },
            {
                "Doaktown", "New Brunswick"
            },
            {
                "Dodsland", "Saskatchewan"
            },
            {
                "Dokis", "Ontario"
            },
            {
                "Dokis First Nation", "Ontario"
            },
            {
                "Dolbeau-Mistassini", "Quebec"
            },
            {
                "Dollard-des-Ormeaux", "Quebec"
            },
            {
                "Dominion City", "Manitoba"
            },
            {
                "Domremy", "Saskatchewan"
            },
            {
                "Donald", "British Columbia"
            },
            {
                "Donalda", "Alberta"
            },
            {
                "Donnacona", "Quebec"
            },
            {
                "Donnelly", "Alberta"
            },
            {
                "Dorchester", "New Brunswick"
            },
            {
                "Dorchester", "Ontario"
            },
            {
                "Dorion", "Ontario"
            },
            {
                "Dorset", "Ontario"
            },
            {
                "Dorval", "Quebec"
            },
            {
                "Douglas", "Ontario"
            },
            {
                "Douglas Lake", "British Columbia"
            },
            {
                "Douglastown", "Ontario"
            },
            {
                "Dover", "Newfoundland"
            },
            {
                "Drake", "Saskatchewan"
            },
            {
                "Drayton", "Ontario"
            },
            {
                "Drayton Valley", "Alberta"
            },
            {
                "Dresden", "Ontario"
            },
            {
                "Drumbo", "Ontario"
            },
            {
                "Drumheller", "Alberta"
            },
            {
                "Drummondville", "Quebec"
            },
            {
                "Dryden", "Ontario"
            },
            {
                "Dublin", "Ontario"
            },
            {
                "Dubreuilville", "Ontario"
            },
            {
                "Dubuc", "Saskatchewan"
            },
            {
                "Dubuisson", "Quebec"
            },
            {
                "Duchess", "Alberta"
            },
            {
                "Duck Lake", "Saskatchewan"
            },
            {
                "Dugald", "Manitoba"
            },
            {
                "Duncan", "British Columbia"
            },
            {
                "Dunchurch", "Ontario"
            },
            {
                "Dundalk", "Ontario"
            },
            {
                "Dundas", "Ontario"
            },
            {
                "Dundee", "Nova Scotia"
            },
            {
                "Dundurn", "Saskatchewan"
            },
            {
                "Dungannon", "Ontario"
            },
            {
                "Dunham", "Quebec"
            },
            {
                "Dunnville", "Ontario"
            },
            {
                "Dunsford", "Ontario"
            },
            {
                "Dunster", "British Columbia"
            },
            {
                "Duparquet", "Quebec"
            },
            {
                "Dupuy", "Quebec"
            },
            {
                "Durham", "Ontario"
            },
            {
                "Dutton", "Ontario"
            },
            {
                "Duvernay", "Quebec"
            },
            {
                "Dwight", "Ontario"
            },
            {
                "Dyer`s Bay", "Ontario"
            },
            {
                "Dysart", "Saskatchewan"
            },
            {
                "D`Arcy", "British Columbia"
            },
            {
                "Eagle Lake First Nation", "Ontario"
            },
            {
                "Eagle River", "Ontario"
            },
            {
                "Eaglesham", "Alberta"
            },
            {
                "Ear Falls", "Ontario"
            },
            {
                "Earl Grey", "Saskatchewan"
            },
            {
                "Earlton", "Ontario"
            },
            {
                "East Angus", "Quebec"
            },
            {
                "East Bay", "Nova Scotia"
            },
            {
                "East Broughton", "Quebec"
            },
            {
                "East Coulee", "Alberta"
            },
            {
                "East Farnham", "Quebec"
            },
            {
                "East Gwillimbury", "Ontario"
            },
            {
                "East Hereford", "Quebec"
            },
            {
                "East Pine", "British Columbia"
            },
            {
                "East Point", "Prince Edward Island"
            },
            {
                "East York", "Ontario"
            },
            {
                "Eastend", "Saskatchewan"
            },
            {
                "Easterville", "Manitoba"
            },
            {
                "Eastmain", "Quebec"
            },
            {
                "Eastman", "Quebec"
            },
            {
                "Eastport", "Newfoundland"
            },
            {
                "Eastwood", "Ontario"
            },
            {
                "Eatonia", "Saskatchewan"
            },
            {
                "Echo Bay", "Ontario"
            },
            {
                "Eckville", "Alberta"
            },
            {
                "Ecum Secum", "Nova Scotia"
            },
            {
                "Edam", "Saskatchewan"
            },
            {
                "Eddystone", "Manitoba"
            },
            {
                "Edgerton", "Alberta"
            },
            {
                "Edmonton", "Alberta"
            },
            {
                "Edmundston", "New Brunswick"
            },
            {
                "Edson", "Alberta"
            },
            {
                "Edwin", "Manitoba"
            },
            {
                "Edzo", "Northwest Territories"
            },
            {
                "Eganville", "Ontario"
            },
            {
                "Elbow", "Saskatchewan"
            },
            {
                "Eldon", "Prince Edward Island"
            },
            {
                "Elfros", "Saskatchewan"
            },
            {
                "Elgin", "Manitoba"
            },
            {
                "Elgin", "Ontario"
            },
            {
                "Elie", "Manitoba"
            },
            {
                "Elizabethtown", "Ontario"
            },
            {
                "Elk Lake", "Ontario"
            },
            {
                "Elk Point", "Alberta"
            },
            {
                "Elkford", "British Columbia"
            },
            {
                "Elkhorn", "Manitoba"
            },
            {
                "Elko", "British Columbia"
            },
            {
                "Elkwater", "Alberta"
            },
            {
                "Elliot Lake", "Ontario"
            },
            {
                "Elliston", "Newfoundland"
            },
            {
                "Elm Creek", "Manitoba"
            },
            {
                "Elmira", "Ontario"
            },
            {
                "Elmsdale", "Nova Scotia"
            },
            {
                "Elmvale", "Ontario"
            },
            {
                "Elnora", "Alberta"
            },
            {
                "Elora", "Ontario"
            },
            {
                "Elrose", "Saskatchewan"
            },
            {
                "Embree", "Newfoundland"
            },
            {
                "Embro", "Ontario"
            },
            {
                "Embrun", "Ontario"
            },
            {
                "Emerson", "Manitoba"
            },
            {
                "Emeryville", "Ontario"
            },
            {
                "Emo", "Ontario"
            },
            {
                "Empress", "Alberta"
            },
            {
                "Emsdale", "Ontario"
            },
            {
                "Enchant", "Alberta"
            },
            {
                "Enderby", "British Columbia"
            },
            {
                "Englee", "Newfoundland"
            },
            {
                "Englehart", "Ontario"
            },
            {
                "English Harbour East", "Newfoundland"
            },
            {
                "Enterprise", "Northwest Territories"
            },
            {
                "Enterprise", "Ontario"
            },
            {
                "Entrelacs", "Quebec"
            },
            {
                "Erickson", "Manitoba"
            },
            {
                "Eriksdale", "Manitoba"
            },
            {
                "Erin", "Ontario"
            },
            {
                "Eskasoni", "Nova Scotia"
            },
            {
                "Espanola", "Ontario"
            },
            {
                "Essex", "Ontario"
            },
            {
                "Estaire", "Ontario"
            },
            {
                "Esterel", "Quebec"
            },
            {
                "Esterhazy", "Saskatchewan"
            },
            {
                "Estevan", "Saskatchewan"
            },
            {
                "Estevan Point", "British Columbia"
            },
            {
                "Eston", "Saskatchewan"
            },
            {
                "Ethelbert", "Manitoba"
            },
            {
                "Etobicoke", "Ontario"
            },
            {
                "Etzikom", "Alberta"
            },
            {
                "Eugenia", "Ontario"
            },
            {
                "Evain", "Quebec"
            },
            {
                "Evansburg", "Alberta"
            },
            {
                "Exeter", "Ontario"
            },
            {
                "Exshaw", "Alberta"
            },
            {
                "Eyebrow", "Saskatchewan"
            },
            {
                "Fabre", "Quebec"
            },
            {
                "Fabreville", "Quebec"
            },
            {
                "Fair Haven", "Newfoundland"
            },
            {
                "Fairmont Hot Springs", "British Columbia"
            },
            {
                "Fairview", "Alberta"
            },
            {
                "Falardeau", "Quebec"
            },
            {
                "Falcon Lake", "Manitoba"
            },
            {
                "Falher", "Alberta"
            },
            {
                "Falkland", "British Columbia"
            },
            {
                "Farnham", "Quebec"
            },
            {
                "Faro", "Yukon"
            },
            {
                "Fassett", "Quebec"
            },
            {
                "Fauquier", "British Columbia"
            },
            {
                "Fauquier", "Ontario"
            },
            {
                "Faust", "Alberta"
            },
            {
                "Fenelon Falls", "Ontario"
            },
            {
                "Fenwick", "Ontario"
            },
            {
                "Fergus", "Ontario"
            },
            {
                "Ferintosh", "Alberta"
            },
            {
                "Ferland", "Quebec"
            },
            {
                "Ferme-Neuve", "Quebec"
            },
            {
                "Fermeuse", "Newfoundland"
            },
            {
                "Fermont", "Quebec"
            },
            {
                "Fernie", "British Columbia"
            },
            {
                "Feversham", "Ontario"
            },
            {
                "Field", "British Columbia"
            },
            {
                "Field", "Ontario"
            },
            {
                "Fillmore", "Saskatchewan"
            },
            {
                "Finch", "Ontario"
            },
            {
                "Fingal", "Ontario"
            },
            {
                "Fisher Branch", "Manitoba"
            },
            {
                "Fisher River", "Manitoba"
            },
            {
                "Fisherville", "Ontario"
            },
            {
                "Flamborough", "Ontario"
            },
            {
                "Flanders", "Ontario"
            },
            {
                "Flatbush", "Alberta"
            },
            {
                "Flatrock", "British Columbia"
            },
            {
                "Flatrock", "Newfoundland"
            },
            {
                "Fleming", "Saskatchewan"
            },
            {
                "Flesherton", "Ontario"
            },
            {
                "Fleur de Lys", "Newfoundland"
            },
            {
                "Fleurimont", "Quebec"
            },
            {
                "Flin Flon", "Manitoba"
            },
            {
                "Florenceville", "New Brunswick"
            },
            {
                "Flower`s Cove", "Newfoundland"
            },
            {
                "Foam Lake", "Saskatchewan"
            },
            {
                "Fogo", "Newfoundland"
            },
            {
                "Foley", "Ontario"
            },
            {
                "Foleyet", "Ontario"
            },
            {
                "Fond-du-Lac", "Saskatchewan"
            },
            {
                "Fords Mills", "New Brunswick"
            },
            {
                "Foremost", "Alberta"
            },
            {
                "Forest", "Ontario"
            },
            {
                "Forest Grove", "British Columbia"
            },
            {
                "Forestburg", "Alberta"
            },
            {
                "Forestville", "Quebec"
            },
            {
                "Fork River", "Manitoba"
            },
            {
                "Fort Albany", "Ontario"
            },
            {
                "Fort Assiniboine", "Alberta"
            },
            {
                "Fort Chipewyan", "Alberta"
            },
            {
                "Fort Erie", "Ontario"
            },
            {
                "Fort Frances", "Ontario"
            },
            {
                "Fort Fraser", "British Columbia"
            },
            {
                "Fort Good Hope", "Northwest Territories"
            },
            {
                "Fort Hope", "Ontario"
            },
            {
                "Fort Liard", "Northwest Territories"
            },
            {
                "Fort MacKay", "Alberta"
            },
            {
                "Fort Macleod", "Alberta"
            },
            {
                "Fort McMurray", "Alberta"
            },
            {
                "Fort McPherson", "Northwest Territories"
            },
            {
                "Fort Nelson", "British Columbia"
            },
            {
                "Fort Providence", "Northwest Territories"
            },
            {
                "Fort Qu`Appelle", "Saskatchewan"
            },
            {
                "Fort Saskatchewan", "Alberta"
            },
            {
                "Fort Severn", "Ontario"
            },
            {
                "Fort Severn First Nation", "Ontario"
            },
            {
                "Fort Simpson", "Northwest Territories"
            },
            {
                "Fort Smith", "Northwest Territories"
            },
            {
                "Fort St. James", "British Columbia"
            },
            {
                "Fort St. John", "British Columbia"
            },
            {
                "Fort Vermilion", "Alberta"
            },
            {
                "Fort William First Nation", "Ontario"
            },
            {
                "Fort-Coulonge", "Quebec"
            },
            {
                "Forteau", "Newfoundland"
            },
            {
                "Fortierville", "Quebec"
            },
            {
                "Fortune", "Newfoundland"
            },
            {
                "Fossambault-sur-le-Lac", "Quebec"
            },
            {
                "Fox Cove-Mortier", "Newfoundland"
            },
            {
                "Fox Creek", "Alberta"
            },
            {
                "Fox Lake", "Alberta"
            },
            {
                "Fox Valley", "Saskatchewan"
            },
            {
                "Foxboro", "Ontario"
            },
            {
                "Foxwarren", "Manitoba"
            },
            {
                "Foymount", "Ontario"
            },
            {
                "Frampton", "Quebec"
            },
            {
                "Francis", "Saskatchewan"
            },
            {
                "Frankford", "Ontario"
            },
            {
                "Franklin Centre", "Quebec"
            },
            {
                "Fraser Lake", "British Columbia"
            },
            {
                "Fredericton", "New Brunswick"
            },
            {
                "Fredericton Junction", "New Brunswick"
            },
            {
                "Freelton", "Ontario"
            },
            {
                "Freeport", "Nova Scotia"
            },
            {
                "Frelighsburg", "Quebec"
            },
            {
                "French River First Nation", "Ontario"
            },
            {
                "French Village", "Nova Scotia"
            },
            {
                "Frenchmans Island", "Newfoundland"
            },
            {
                "Freshwater", "Newfoundland"
            },
            {
                "Frobisher", "Saskatchewan"
            },
            {
                "Frontier", "Saskatchewan"
            },
            {
                "Fruitvale", "British Columbia"
            },
            {
                "Fugereville", "Quebec"
            },
            {
                "Gabarus", "Nova Scotia"
            },
            {
                "Gabriola", "British Columbia"
            },
            {
                "Gadsby", "Alberta"
            },
            {
                "Gagetown", "New Brunswick"
            },
            {
                "Gainsborough", "Saskatchewan"
            },
            {
                "Galahad", "Alberta"
            },
            {
                "Galiano Island", "British Columbia"
            },
            {
                "Galt", "Ontario"
            },
            {
                "Gambo", "Newfoundland"
            },
            {
                "Gananoque", "Ontario"
            },
            {
                "Gander", "Newfoundland"
            },
            {
                "Ganges", "British Columbia"
            },
            {
                "Garden Hill", "Ontario"
            },
            {
                "Garden River First Nation", "Ontario"
            },
            {
                "Garnish", "Newfoundland"
            },
            {
                "Garson", "Ontario"
            },
            {
                "Gaspe", "Quebec"
            },
            {
                "Gatineau", "Quebec"
            },
            {
                "Gaultois", "Newfoundland"
            },
            {
                "Gentilly", "Quebec"
            },
            {
                "Georgetown", "Ontario"
            },
            {
                "Georgetown", "Prince Edward Island"
            },
            {
                "Georgina", "Ontario"
            },
            {
                "Geraldton", "Ontario"
            },
            {
                "Gibbons", "Alberta"
            },
            {
                "Gibsons", "British Columbia"
            },
            {
                "Gift Lake", "Alberta"
            },
            {
                "Gilbert Plains", "Manitoba"
            },
            {
                "Gillam", "Manitoba"
            },
            {
                "Gilmour", "Ontario"
            },
            {
                "Gimli", "Manitoba"
            },
            {
                "Girardville", "Quebec"
            },
            {
                "Girouxville", "Alberta"
            },
            {
                "Giscome", "British Columbia"
            },
            {
                "Gjoa Haven", "Nunavut"
            },
            {
                "Glace Bay", "Nova Scotia"
            },
            {
                "Gladstone", "Manitoba"
            },
            {
                "Glaslyn", "Saskatchewan"
            },
            {
                "Glassville", "New Brunswick"
            },
            {
                "Gleichen", "Alberta"
            },
            {
                "Glen Ewen", "Saskatchewan"
            },
            {
                "Glen Robertson", "Ontario"
            },
            {
                "Glen Water", "Ontario"
            },
            {
                "Glen Williams", "Ontario"
            },
            {
                "Glenavon", "Saskatchewan"
            },
            {
                "Glenboro", "Manitoba"
            },
            {
                "Glencoe", "Ontario"
            },
            {
                "Glendon", "Alberta"
            },
            {
                "Glenella", "Manitoba"
            },
            {
                "Glenwood", "Alberta"
            },
            {
                "Glenwood", "Newfoundland"
            },
            {
                "Gloucester", "Ontario"
            },
            {
                "Glovertown", "Newfoundland"
            },
            {
                "Godbout", "Quebec"
            },
            {
                "Goderich", "Ontario"
            },
            {
                "Gods Lake Narrows", "Manitoba"
            },
            {
                "Gogama", "Ontario"
            },
            {
                "Gold Bridge", "British Columbia"
            },
            {
                "Gold River", "British Columbia"
            },
            {
                "Goldboro", "Nova Scotia"
            },
            {
                "Golden", "British Columbia"
            },
            {
                "Golden Lake", "Ontario"
            },
            {
                "Good Hope Lake", "British Columbia"
            },
            {
                "Gooderham", "Ontario"
            },
            {
                "Goodeve", "Saskatchewan"
            },
            {
                "Goodsoil", "Saskatchewan"
            },
            {
                "Goose Bay", "Newfoundland"
            },
            {
                "Gore Bay", "Ontario"
            },
            {
                "Gormley", "Ontario"
            },
            {
                "Gorrie", "Ontario"
            },
            {
                "Goshen", "Nova Scotia"
            },
            {
                "Goulais River", "Ontario"
            },
            {
                "Govan", "Saskatchewan"
            },
            {
                "Gowganda", "Ontario"
            },
            {
                "Gracefield", "Quebec"
            },
            {
                "Grafton", "Ontario"
            },
            {
                "Granby", "Quebec"
            },
            {
                "Grand Bank", "Newfoundland"
            },
            {
                "Grand Bay", "New Brunswick"
            },
            {
                "Grand Beach", "Manitoba"
            },
            {
                "Grand Bend", "Ontario"
            },
            {
                "Grand Centre", "Alberta"
            },
            {
                "Grand Etang", "Nova Scotia"
            },
            {
                "Grand Falls", "New Brunswick"
            },
            {
                "Grand Falls", "Newfoundland"
            },
            {
                "Grand Falls-Windsor", "Newfoundland"
            },
            {
                "Grand Forks", "British Columbia"
            },
            {
                "Grand Lake", "Nova Scotia"
            },
            {
                "Grand Manan", "New Brunswick"
            },
            {
                "Grand Narrows", "Nova Scotia"
            },
            {
                "Grand Rapids", "Manitoba"
            },
            {
                "Grand Valley", "Ontario"
            },
            {
                "Grand-Mere", "Quebec"
            },
            {
                "Grand-Remous", "Quebec"
            },
            {
                "Grand-Sault", "New Brunswick"
            },
            {
                "Grande Cache", "Alberta"
            },
            {
                "Grande Prairie", "Alberta"
            },
            {
                "Grande-Anse", "New Brunswick"
            },
            {
                "Grande-Entree", "Quebec"
            },
            {
                "Grande-Riviere", "Quebec"
            },
            {
                "Grande-Vallee", "Quebec"
            },
            {
                "Grandes-Bergeronnes", "Quebec"
            },
            {
                "Grandes-Piles", "Quebec"
            },
            {
                "Grandview", "Manitoba"
            },
            {
                "Granisle", "British Columbia"
            },
            {
                "Granton", "Ontario"
            },
            {
                "Granum", "Alberta"
            },
            {
                "Grasmere", "British Columbia"
            },
            {
                "Grassland", "Alberta"
            },
            {
                "Grassy Lake", "Alberta"
            },
            {
                "Grassy Narrows", "Ontario"
            },
            {
                "Grassy Narrows First Nation", "Ontario"
            },
            {
                "Grassy Plains", "British Columbia"
            },
            {
                "Gravelbourg", "Saskatchewan"
            },
            {
                "Gravenhurst", "Ontario"
            },
            {
                "Grayson", "Saskatchewan"
            },
            {
                "Great Harbour Deep", "Newfoundland"
            },
            {
                "Great Village", "Nova Scotia"
            },
            {
                "Green Island Cove", "Newfoundland"
            },
            {
                "Green Lake", "Saskatchewan"
            },
            {
                "Greenfield Park", "Quebec"
            },
            {
                "Greenspond", "Newfoundland"
            },
            {
                "Greensville", "Ontario"
            },
            {
                "Greenville", "British Columbia"
            },
            {
                "Greenwood", "British Columbia"
            },
            {
                "Greenwood", "Nova Scotia"
            },
            {
                "Grenfell", "Saskatchewan"
            },
            {
                "Grenville", "Quebec"
            },
            {
                "Gretna", "Manitoba"
            },
            {
                "Grimsby", "Ontario"
            },
            {
                "Grimshaw", "Alberta"
            },
            {
                "Grouard", "Alberta"
            },
            {
                "Guelph", "Ontario"
            },
            {
                "Guigues", "Quebec"
            },
            {
                "Gull Bay", "Ontario"
            },
            {
                "Gull Bay First Nation", "Ontario"
            },
            {
                "Gull Lake", "Saskatchewan"
            },
            {
                "Guysborough", "Nova Scotia"
            },
            {
                "Gypsumville", "Manitoba"
            },
            {
                "Hadashville", "Manitoba"
            },
            {
                "Hafford", "Saskatchewan"
            },
            {
                "Hagersville", "Ontario"
            },
            {
                "Hague", "Saskatchewan"
            },
            {
                "Haileybury", "Ontario"
            },
            {
                "Haines Junction", "Yukon"
            },
            {
                "Hairy Hill", "Alberta"
            },
            {
                "Haldimand", "Ontario"
            },
            {
                "Haliburton", "Ontario"
            },
            {
                "Halifax", "Nova Scotia"
            },
            {
                "Halkirk", "Alberta"
            },
            {
                "Halton Hills", "Ontario"
            },
            {
                "Ham-Nord", "Quebec"
            },
            {
                "Hamilton", "Ontario"
            },
            {
                "Hamiota", "Manitoba"
            },
            {
                "Hammond", "Quebec"
            },
            {
                "Hampden", "Newfoundland"
            },
            {
                "Hampstead", "New Brunswick"
            },
            {
                "Hampstead", "Quebec"
            },
            {
                "Hampton", "New Brunswick"
            },
            {
                "Hampton", "Ontario"
            },
            {
                "Hanley", "Saskatchewan"
            },
            {
                "Hanmer", "Ontario"
            },
            {
                "Hanna", "Alberta"
            },
            {
                "Hanover", "Ontario"
            },
            {
                "Hantsport", "Nova Scotia"
            },
            {
                "Hant`s Harbour", "Newfoundland"
            },
            {
                "Happy Valley-Goose Bay", "Newfoundland"
            },
            {
                "Harbour Breton", "Newfoundland"
            },
            {
                "Harbour Grace", "Newfoundland"
            },
            {
                "Harbour Main-Chapel Cove-Lakev", "Newfoundland"
            },
            {
                "Hardisty", "Alberta"
            },
            {
                "Hare Bay", "Newfoundland"
            },
            {
                "Harewood", "New Brunswick"
            },
            {
                "Harrietsville", "Ontario"
            },
            {
                "Harrington Harbour", "Quebec"
            },
            {
                "Harris", "Saskatchewan"
            },
            {
                "Harriston", "Ontario"
            },
            {
                "Harrow", "Ontario"
            },
            {
                "Harrowsmith", "Ontario"
            },
            {
                "Hartland", "New Brunswick"
            },
            {
                "Hartley Bay", "British Columbia"
            },
            {
                "Hartney", "Manitoba"
            },
            {
                "Hastings", "Ontario"
            },
            {
                "Havelock", "New Brunswick"
            },
            {
                "Havelock", "Ontario"
            },
            {
                "Havre-Aubert", "Quebec"
            },
            {
                "Havre-aux-Maisons", "Quebec"
            },
            {
                "Havre-St-Pierre", "Quebec"
            },
            {
                "Hawarden", "Saskatchewan"
            },
            {
                "Hawk Junction", "Ontario"
            },
            {
                "Hawkesbury", "Ontario"
            },
            {
                "Hawke`s Bay", "Newfoundland"
            },
            {
                "Hay Lakes", "Alberta"
            },
            {
                "Hay River", "Northwest Territories"
            },
            {
                "Hays", "Alberta"
            },
            {
                "Hazelton", "British Columbia"
            },
            {
                "Hazlet", "Saskatchewan"
            },
            {
                "Hearst", "Ontario"
            },
            {
                "Heart`s Content", "Newfoundland"
            },
            {
                "Heart`s Delight-Islington", "Newfoundland"
            },
            {
                "Heart`s Desire", "Newfoundland"
            },
            {
                "Heatherton", "Nova Scotia"
            },
            {
                "Hebertville", "Quebec"
            },
            {
                "Hebertville-Station", "Quebec"
            },
            {
                "Hecla", "Manitoba"
            },
            {
                "Hedley", "British Columbia"
            },
            {
                "Heinsburg", "Alberta"
            },
            {
                "Heisler", "Alberta"
            },
            {
                "Hemlo", "Ontario"
            },
            {
                "Hemlock Valley", "British Columbia"
            },
            {
                "Hemmingford", "Quebec"
            },
            {
                "Hendrix Lake", "British Columbia"
            },
            {
                "Henryville", "Quebec"
            },
            {
                "Hensall", "Ontario"
            },
            {
                "Henvey Inlet First Nation", "Ontario"
            },
            {
                "Hepburn", "Saskatchewan"
            },
            {
                "Hepworth", "Ontario"
            },
            {
                "Herbert", "Saskatchewan"
            },
            {
                "Herschel", "Saskatchewan"
            },
            {
                "Hespeler", "Ontario"
            },
            {
                "Hickman`s Harbour", "Newfoundland"
            },
            {
                "Hickson", "Ontario"
            },
            {
                "High Level", "Alberta"
            },
            {
                "High Prairie", "Alberta"
            },
            {
                "High River", "Alberta"
            },
            {
                "Highgate", "Ontario"
            },
            {
                "Hilda", "Alberta"
            },
            {
                "Hillgrade", "Newfoundland"
            },
            {
                "Hillsborough", "New Brunswick"
            },
            {
                "Hillsburgh", "Ontario"
            },
            {
                "Hillview", "Newfoundland"
            },
            {
                "Hines Creek", "Alberta"
            },
            {
                "Hinton", "Alberta"
            },
            {
                "Hixon", "British Columbia"
            },
            {
                "Hobbema", "Alberta"
            },
            {
                "Hodgeville", "Saskatchewan"
            },
            {
                "Holberg", "British Columbia"
            },
            {
                "Holden", "Alberta"
            },
            {
                "Holdfast", "Saskatchewan"
            },
            {
                "Holland", "Manitoba"
            },
            {
                "Holland Landing", "Ontario"
            },
            {
                "Holstein", "Ontario"
            },
            {
                "Holyrood", "Newfoundland"
            },
            {
                "Honey Harbour", "Ontario"
            },
            {
                "Hope", "British Columbia"
            },
            {
                "Hopedale", "Newfoundland"
            },
            {
                "Hopewell", "Nova Scotia"
            },
            {
                "Hornepayne", "Ontario"
            },
            {
                "Horsefly", "British Columbia"
            },
            {
                "Houston", "British Columbia"
            },
            {
                "Howick", "Quebec"
            },
            {
                "Howley", "Newfoundland"
            },
            {
                "Hoyt", "New Brunswick"
            },
            {
                "Hubbards", "Nova Scotia"
            },
            {
                "Hudson", "Ontario"
            },
            {
                "Hudson", "Quebec"
            },
            {
                "Hudson Bay", "Saskatchewan"
            },
            {
                "Hudson`s Hope", "British Columbia"
            },
            {
                "Hughenden", "Alberta"
            },
            {
                "Hull", "Quebec"
            },
            {
                "Humber Arm South", "Newfoundland"
            },
            {
                "Humboldt", "Saskatchewan"
            },
            {
                "Humphrey", "Ontario"
            },
            {
                "Hunter River", "Prince Edward Island"
            },
            {
                "Huntingdon", "Quebec"
            },
            {
                "Huntsville", "Ontario"
            },
            {
                "Hussar", "Alberta"
            },
            {
                "Hythe", "Alberta"
            },
            {
                "Iberville", "Quebec"
            },
            {
                "Ignace", "Ontario"
            },
            {
                "Ilderton", "Ontario"
            },
            {
                "Ile-a-la-Crosse", "Saskatchewan"
            },
            {
                "Ile-aux-Coudres", "Quebec"
            },
            {
                "Iles-de-la-Madeleine", "Quebec"
            },
            {
                "Ilford", "Manitoba"
            },
            {
                "Imperial", "Saskatchewan"
            },
            {
                "Indian Head", "Saskatchewan"
            },
            {
                "Indian Tickle", "Newfoundland"
            },
            {
                "Ingersoll", "Ontario"
            },
            {
                "Ingleside", "Ontario"
            },
            {
                "Ingonish", "Nova Scotia"
            },
            {
                "Innerkip", "Ontario"
            },
            {
                "Innisfail", "Alberta"
            },
            {
                "Innisfil", "Ontario"
            },
            {
                "Innisfree", "Alberta"
            },
            {
                "Inukjuak", "Quebec"
            },
            {
                "Inuvik", "Northwest Territories"
            },
            {
                "Inverary", "Ontario"
            },
            {
                "Invermay", "Saskatchewan"
            },
            {
                "Invermere", "British Columbia"
            },
            {
                "Inverness", "Nova Scotia"
            },
            {
                "Inverness", "Quebec"
            },
            {
                "Inwood", "Manitoba"
            },
            {
                "Inwood", "Ontario"
            },
            {
                "Iqaluit", "Nunavut"
            },
            {
                "Irma", "Alberta"
            },
            {
                "Iron Bridge", "Ontario"
            },
            {
                "Iron Springs", "Alberta"
            },
            {
                "Iroquois", "Ontario"
            },
            {
                "Iroquois Falls", "Ontario"
            },
            {
                "Irricana", "Alberta"
            },
            {
                "Irvine", "Alberta"
            },
            {
                "Iskut", "British Columbia"
            },
            {
                "Island Harbour", "Newfoundland"
            },
            {
                "Island Lake", "Manitoba"
            },
            {
                "Islay", "Alberta"
            },
            {
                "Isle aux Morts", "Newfoundland"
            },
            {
                "Ituna", "Saskatchewan"
            },
            {
                "Jackson`s Arm", "Newfoundland"
            },
            {
                "Jacquet River", "New Brunswick"
            },
            {
                "Jaffray", "British Columbia"
            },
            {
                "Jaffray Melick", "Ontario"
            },
            {
                "Jamestown", "Newfoundland"
            },
            {
                "Jansen", "Saskatchewan"
            },
            {
                "Jarvie", "Alberta"
            },
            {
                "Jarvis", "Ontario"
            },
            {
                "Jasper", "Alberta"
            },
            {
                "Jasper", "Ontario"
            },
            {
                "Jean Marie River", "Northwest Territories"
            },
            {
                "Jellicoe", "Ontario"
            },
            {
                "Jenner", "Alberta"
            },
            {
                "Jockvale", "Ontario"
            },
            {
                "Joe Batt`s Arm-Barr`d Islands-", "Newfoundland"
            },
            {
                "Johnstown", "Ontario"
            },
            {
                "Joliette", "Quebec"
            },
            {
                "Jonquiere", "Quebec"
            },
            {
                "Jordan", "Ontario"
            },
            {
                "Joussard", "Alberta"
            },
            {
                "Joutel", "Quebec"
            },
            {
                "Kakisa", "Northwest Territories"
            },
            {
                "Kaministiquia", "Ontario"
            },
            {
                "Kamiskotia", "Ontario"
            },
            {
                "Kamloops", "British Columbia"
            },
            {
                "Kamsack", "Saskatchewan"
            },
            {
                "Kananaskis", "Alberta"
            },
            {
                "Kanata", "Ontario"
            },
            {
                "Kangiqsualujjuaq", "Quebec"
            },
            {
                "Kangirsuk", "Quebec"
            },
            {
                "Kapuskasing", "Ontario"
            },
            {
                "Kasabonika First Nation", "Ontario"
            },
            {
                "Kashechewan First Nation", "Ontario"
            },
            {
                "Kaslo", "British Columbia"
            },
            {
                "Kateville", "Quebec"
            },
            {
                "Kazabazua", "Quebec"
            },
            {
                "Kearney", "Ontario"
            },
            {
                "Kedgwick", "New Brunswick"
            },
            {
                "Keene", "Ontario"
            },
            {
                "Keephills", "Alberta"
            },
            {
                "Keewatin", "Ontario"
            },
            {
                "Keg River", "Alberta"
            },
            {
                "Kelliher", "Saskatchewan"
            },
            {
                "Kelowna", "British Columbia"
            },
            {
                "Kelvington", "Saskatchewan"
            },
            {
                "Kelwood", "Manitoba"
            },
            {
                "Kemano", "British Columbia"
            },
            {
                "Kemptville", "Ontario"
            },
            {
                "Kenaston", "Saskatchewan"
            },
            {
                "Kennedy", "Saskatchewan"
            },
            {
                "Kennetcook", "Nova Scotia"
            },
            {
                "Kenora", "Ontario"
            },
            {
                "Kenosee", "Saskatchewan"
            },
            {
                "Kensington", "Prince Edward Island"
            },
            {
                "Kent Centre", "Ontario"
            },
            {
                "Kenton", "Manitoba"
            },
            {
                "Kentville", "Nova Scotia"
            },
            {
                "Kenzieville", "Nova Scotia"
            },
            {
                "Keremeos", "British Columbia"
            },
            {
                "Kerrobert", "Saskatchewan"
            },
            {
                "Kerwood", "Ontario"
            },
            {
                "Keswick", "New Brunswick"
            },
            {
                "Keswick", "Ontario"
            },
            {
                "Ketch Harbour", "Nova Scotia"
            },
            {
                "Key Lake", "Saskatchewan"
            },
            {
                "Killaloe", "Ontario"
            },
            {
                "Killam", "Alberta"
            },
            {
                "Killarney", "Manitoba"
            },
            {
                "Killarney", "Ontario"
            },
            {
                "Kimberley", "British Columbia"
            },
            {
                "Kincaid", "Saskatchewan"
            },
            {
                "Kincardine", "Ontario"
            },
            {
                "Kincolith", "British Columbia"
            },
            {
                "Kindersley", "Saskatchewan"
            },
            {
                "King City", "Ontario"
            },
            {
                "Kingfisher Lake", "Ontario"
            },
            {
                "Kingfisher Lake First Nation", "Ontario"
            },
            {
                "Kingsbury", "Quebec"
            },
            {
                "Kingsey Falls", "Quebec"
            },
            {
                "Kingston", "Nova Scotia"
            },
            {
                "Kingston", "Ontario"
            },
            {
                "Kingsville", "Ontario"
            },
            {
                "King`s Cove", "Newfoundland"
            },
            {
                "King`s Point", "Newfoundland"
            },
            {
                "Kinistino", "Saskatchewan"
            },
            {
                "Kinmount", "Ontario"
            },
            {
                "Kintore", "Ontario"
            },
            {
                "Kinuso", "Alberta"
            },
            {
                "Kipling", "Saskatchewan"
            },
            {
                "Kippens", "Newfoundland"
            },
            {
                "Kirkfield", "Ontario"
            },
            {
                "Kirkland", "Quebec"
            },
            {
                "Kirkland Lake", "Ontario"
            },
            {
                "Kirkton", "Ontario"
            },
            {
                "Kisbey", "Saskatchewan"
            },
            {
                "Kitchener", "Ontario"
            },
            {
                "Kitimat", "British Columbia"
            },
            {
                "Kitkatla", "British Columbia"
            },
            {
                "Kitsault", "British Columbia"
            },
            {
                "Kitscoty", "Alberta"
            },
            {
                "Kitwanga", "British Columbia"
            },
            {
                "Kleinburg", "Ontario"
            },
            {
                "Klemtu", "British Columbia"
            },
            {
                "Knowlton", "Quebec"
            },
            {
                "Kugluktuk", "Northwest Territories"
            },
            {
                "Kuujjuaq", "Quebec"
            },
            {
                "Kyle", "Saskatchewan"
            },
            {
                "Kyuquot", "British Columbia"
            },
            {
                "La Baie", "Quebec"
            },
            {
                "La Broquerie", "Manitoba"
            },
            {
                "La Corne", "Quebec"
            },
            {
                "La Crete", "Alberta"
            },
            {
                "La Dore", "Quebec"
            },
            {
                "La Grande", "Quebec"
            },
            {
                "La Guadeloupe", "Quebec"
            },
            {
                "La Loche", "Saskatchewan"
            },
            {
                "La Malbaie", "Quebec"
            },
            {
                "La Martre", "Quebec"
            },
            {
                "La Minerve", "Quebec"
            },
            {
                "La Patrie", "Quebec"
            },
            {
                "La Plaine", "Quebec"
            },
            {
                "La Pocatiere", "Quebec"
            },
            {
                "La Prairie", "Quebec"
            },
            {
                "La Reine", "Quebec"
            },
            {
                "La Romaine", "Quebec"
            },
            {
                "La Ronge", "Saskatchewan"
            },
            {
                "La Sarre", "Quebec"
            },
            {
                "La Scie", "Newfoundland"
            },
            {
                "La Tuque", "Quebec"
            },
            {
                "Labelle", "Quebec"
            },
            {
                "Labrador City", "Newfoundland"
            },
            {
                "Lac Brochet", "Manitoba"
            },
            {
                "Lac du Bonnet", "Manitoba"
            },
            {
                "Lac Kenogami", "Quebec"
            },
            {
                "Lac La Biche", "Alberta"
            },
            {
                "Lac la Croix", "Ontario"
            },
            {
                "Lac la Hache", "British Columbia"
            },
            {
                "Lac Seul First Nation", "Ontario"
            },
            {
                "Lac-au-Saumon", "Quebec"
            },
            {
                "Lac-aux-Sables", "Quebec"
            },
            {
                "Lac-Bouchette", "Quebec"
            },
            {
                "Lac-Brome", "Quebec"
            },
            {
                "Lac-Delage", "Quebec"
            },
            {
                "Lac-des-Ecorces", "Quebec"
            },
            {
                "Lac-Drolet", "Quebec"
            },
            {
                "Lac-du-Cerf", "Quebec"
            },
            {
                "Lac-Edouard", "Quebec"
            },
            {
                "Lac-Etchemin", "Quebec"
            },
            {
                "Lac-Frontiere", "Quebec"
            },
            {
                "Lac-Poulin", "Quebec"
            },
            {
                "Lac-Saguay", "Quebec"
            },
            {
                "Lac-Sergent", "Quebec"
            },
            {
                "Lac-St-Joseph", "Quebec"
            },
            {
                "Lachenaie", "Quebec"
            },
            {
                "Lachine", "Quebec"
            },
            {
                "Lachute", "Quebec"
            },
            {
                "Lacolle", "Quebec"
            },
            {
                "Lacombe", "Alberta"
            },
            {
                "Ladle Cove", "Newfoundland"
            },
            {
                "Ladysmith", "British Columbia"
            },
            {
                "Lafleche", "Saskatchewan"
            },
            {
                "Lafontaine", "Ontario"
            },
            {
                "Lafontaine", "Quebec"
            },
            {
                "Lagoon City", "Ontario"
            },
            {
                "LaHave", "Nova Scotia"
            },
            {
                "Laird", "Saskatchewan"
            },
            {
                "Lake Alma", "Saskatchewan"
            },
            {
                "Lake Charlotte", "Nova Scotia"
            },
            {
                "Lake Cowichan", "British Columbia"
            },
            {
                "Lake Lenore", "Saskatchewan"
            },
            {
                "Lake Louise", "Alberta"
            },
            {
                "Lake Megantic", "Quebec"
            },
            {
                "Lakefield", "Ontario"
            },
            {
                "Lamaline", "Newfoundland"
            },
            {
                "Lambeth", "Ontario"
            },
            {
                "Lambton", "Quebec"
            },
            {
                "Lameque", "New Brunswick"
            },
            {
                "Lamont", "Alberta"
            },
            {
                "Lampman", "Saskatchewan"
            },
            {
                "Lanark", "Ontario"
            },
            {
                "Lancaster", "Ontario"
            },
            {
                "Landis", "Saskatchewan"
            },
            {
                "Lang", "Saskatchewan"
            },
            {
                "Langara", "British Columbia"
            },
            {
                "Langdon", "Alberta"
            },
            {
                "Langenburg", "Saskatchewan"
            },
            {
                "Langham", "Saskatchewan"
            },
            {
                "Langley", "British Columbia"
            },
            {
                "Langruth", "Manitoba"
            },
            {
                "Langton", "Ontario"
            },
            {
                "Lanigan", "Saskatchewan"
            },
            {
                "Lanoraie", "Quebec"
            },
            {
                "Lansdowne", "Ontario"
            },
            {
                "Lansdowne House", "Ontario"
            },
            {
                "Lantzville", "British Columbia"
            },
            {
                "Larder Lake", "Ontario"
            },
            {
                "Lark Harbour", "Newfoundland"
            },
            {
                "Larrys River", "Nova Scotia"
            },
            {
                "LaSalle", "Ontario"
            },
            {
                "LaSalle", "Quebec"
            },
            {
                "Lashburn", "Saskatchewan"
            },
            {
                "Latchford", "Ontario"
            },
            {
                "Laterriere", "Quebec"
            },
            {
                "Latulipe", "Quebec"
            },
            {
                "Laurentides", "Quebec"
            },
            {
                "Laurier-Station", "Quebec"
            },
            {
                "Laurierville", "Quebec"
            },
            {
                "Laval", "Quebec"
            },
            {
                "Laval des Rapides", "Quebec"
            },
            {
                "Laval Ouest", "Quebec"
            },
            {
                "Lavaltrie", "Quebec"
            },
            {
                "Laverlochere", "Quebec"
            },
            {
                "Lavoy", "Alberta"
            },
            {
                "Lawn", "Newfoundland"
            },
            {
                "Lawrencetown", "Nova Scotia"
            },
            {
                "Lawrenceville", "Quebec"
            },
            {
                "Le Bic", "Quebec"
            },
            {
                "Le Gardeur", "Quebec"
            },
            {
                "Leader", "Saskatchewan"
            },
            {
                "Leaf Rapids", "Manitoba"
            },
            {
                "Leamington", "Ontario"
            },
            {
                "Leask", "Saskatchewan"
            },
            {
                "Lebel-sur-Quevillon", "Quebec"
            },
            {
                "Leclercville", "Quebec"
            },
            {
                "Leduc", "Alberta"
            },
            {
                "Lefroy", "Ontario"
            },
            {
                "Legal", "Alberta"
            },
            {
                "Lemberg", "Saskatchewan"
            },
            {
                "LeMoyne", "Quebec"
            },
            {
                "Lennoxville", "Quebec"
            },
            {
                "Leoville", "Saskatchewan"
            },
            {
                "Leroy", "Saskatchewan"
            },
            {
                "Lery", "Quebec"
            },
            {
                "Les Boules", "Quebec"
            },
            {
                "Les Cedres", "Quebec"
            },
            {
                "Les Coteaux", "Quebec"
            },
            {
                "Les Eboulements", "Quebec"
            },
            {
                "Les Escoumins", "Quebec"
            },
            {
                "Les Mechins", "Quebec"
            },
            {
                "Leslieville", "Alberta"
            },
            {
                "Lestock", "Saskatchewan"
            },
            {
                "Lethbridge", "Alberta"
            },
            {
                "Levack", "Ontario"
            },
            {
                "Levis", "Quebec"
            },
            {
                "Lewisporte", "Newfoundland"
            },
            {
                "Libau", "Manitoba"
            },
            {
                "Liberty", "Saskatchewan"
            },
            {
                "Likely", "British Columbia"
            },
            {
                "Lillooet", "British Columbia"
            },
            {
                "Limerick", "Saskatchewan"
            },
            {
                "Lincoln", "Ontario"
            },
            {
                "Lindsay", "Ontario"
            },
            {
                "Lintlaw", "Saskatchewan"
            },
            {
                "Linwood", "Ontario"
            },
            {
                "Lion`s Head", "Ontario"
            },
            {
                "Lipton", "Saskatchewan"
            },
            {
                "Listowel", "Ontario"
            },
            {
                "Little Bay", "Newfoundland"
            },
            {
                "Little Bay Islands", "Newfoundland"
            },
            {
                "Little Britain", "Ontario"
            },
            {
                "Little Burnt Bay", "Newfoundland"
            },
            {
                "Little Catalina", "Newfoundland"
            },
            {
                "Little Current", "Ontario"
            },
            {
                "Little Fort", "British Columbia"
            },
            {
                "Little Grand Rapids", "Manitoba"
            },
            {
                "Little Heart`s Ease", "Newfoundland"
            },
            {
                "Lively", "Ontario"
            },
            {
                "Liverpool", "Nova Scotia"
            },
            {
                "Lloydminster", "Alberta"
            },
            {
                "Lloydminster", "Saskatchewan"
            },
            {
                "Lockeport", "Nova Scotia"
            },
            {
                "Lockport", "Manitoba"
            },
            {
                "Lodgepole", "Alberta"
            },
            {
                "Logan Lake", "British Columbia"
            },
            {
                "Logy Bay-Middle Cove-Outer Cov", "Newfoundland"
            },
            {
                "Lombardy", "Ontario"
            },
            {
                "Lomond", "Alberta"
            },
            {
                "London", "Ontario"
            },
            {
                "Long Harbour-Mount Arlington H", "Newfoundland"
            },
            {
                "Long Lac", "Ontario"
            },
            {
                "Long Lake First Nation", "Ontario"
            },
            {
                "Long Point", "Ontario"
            },
            {
                "Long Pond", "Newfoundland"
            },
            {
                "Long Sault", "Ontario"
            },
            {
                "Longlac", "Ontario"
            },
            {
                "Longueuil", "Quebec"
            },
            {
                "Longview", "Alberta"
            },
            {
                "Loon Lake", "Saskatchewan"
            },
            {
                "Loos", "British Columbia"
            },
            {
                "Loreburn", "Saskatchewan"
            },
            {
                "Loretteville", "Quebec"
            },
            {
                "Lorne", "Ontario"
            },
            {
                "Lorraine", "Quebec"
            },
            {
                "Lorrainville", "Quebec"
            },
            {
                "Lougheed", "Alberta"
            },
            {
                "Louisbourg", "Nova Scotia"
            },
            {
                "Louisdale", "Nova Scotia"
            },
            {
                "Louiseville", "Quebec"
            },
            {
                "Lourdes", "Newfoundland"
            },
            {
                "Lourdes de Blanc Sablon", "Quebec"
            },
            {
                "Louvicourt", "Quebec"
            },
            {
                "Low", "Quebec"
            },
            {
                "Lower Island Cove", "Newfoundland"
            },
            {
                "Lower Post", "British Columbia"
            },
            {
                "Lucan", "Ontario"
            },
            {
                "Luceville", "Quebec"
            },
            {
                "Lucknow", "Ontario"
            },
            {
                "Lucky Lake", "Saskatchewan"
            },
            {
                "Lumby", "British Columbia"
            },
            {
                "Lumsden", "Newfoundland"
            },
            {
                "Lumsden", "Saskatchewan"
            },
            {
                "Lundar", "Manitoba"
            },
            {
                "Lunenburg", "Nova Scotia"
            },
            {
                "Luseland", "Saskatchewan"
            },
            {
                "Luskville", "Quebec"
            },
            {
                "Lyn", "Ontario"
            },
            {
                "Lynden", "Ontario"
            },
            {
                "Lynn Lake", "Manitoba"
            },
            {
                "Lyster", "Quebec"
            },
            {
                "Lytton", "British Columbia"
            },
            {
                "L`Acadie", "Quebec"
            },
            {
                "L`Ancienne-Lorette", "Quebec"
            },
            {
                "L`Ange-Gardien", "Quebec"
            },
            {
                "L`Annonciation", "Quebec"
            },
            {
                "L`Anse-au-Loup", "Newfoundland"
            },
            {
                "L`Ardoise", "Nova Scotia"
            },
            {
                "L`Assomption", "Quebec"
            },
            {
                "L`Avenir", "Quebec"
            },
            {
                "L`Epiphanie", "Quebec"
            },
            {
                "L`Ile-Aux-Noix", "Quebec"
            },
            {
                "L`Ile-Bizard", "Quebec"
            },
            {
                "L`Ile-Cadieux", "Quebec"
            },
            {
                "L`Ile-Dorval", "Quebec"
            },
            {
                "L`Ile-d`Entree", "Quebec"
            },
            {
                "L`Ile-Perrot", "Quebec"
            },
            {
                "L`Île-Verte", "Quebec"
            },
            {
                "L`Islet", "Quebec"
            },
            {
                "L`Orignal", "Ontario"
            },
            {
                "Ma-Me-O Beach", "Alberta"
            },
            {
                "Maberly", "Ontario"
            },
            {
                "Mabou", "Nova Scotia"
            },
            {
                "Macamic", "Quebec"
            },
            {
                "Maccan", "Nova Scotia"
            },
            {
                "Macdiarmid", "Ontario"
            },
            {
                "Maces Bay", "New Brunswick"
            },
            {
                "MacGregor", "Manitoba"
            },
            {
                "Mackenzie", "British Columbia"
            },
            {
                "Macklin", "Saskatchewan"
            },
            {
                "Macrorie", "Saskatchewan"
            },
            {
                "MacTier", "Ontario"
            },
            {
                "Madoc", "Ontario"
            },
            {
                "Madsen", "Ontario"
            },
            {
                "Mafeking", "Manitoba"
            },
            {
                "Magnetawan", "Ontario"
            },
            {
                "Magnetawan First Nation", "Ontario"
            },
            {
                "Magog", "Quebec"
            },
            {
                "Magrath", "Alberta"
            },
            {
                "Mahone Bay", "Nova Scotia"
            },
            {
                "Maidstone", "Ontario"
            },
            {
                "Maidstone", "Saskatchewan"
            },
            {
                "Main Brook", "Newfoundland"
            },
            {
                "Maitland", "Nova Scotia"
            },
            {
                "Maitland", "Ontario"
            },
            {
                "Makkovik", "Newfoundland"
            },
            {
                "Malartic", "Quebec"
            },
            {
                "Mallorytown", "Ontario"
            },
            {
                "Malton", "Ontario"
            },
            {
                "Manic-Cinq", "Quebec"
            },
            {
                "Manigotagan", "Manitoba"
            },
            {
                "Manitou", "Manitoba"
            },
            {
                "Manitouwadge", "Ontario"
            },
            {
                "Manitowaning", "Ontario"
            },
            {
                "Maniwaki", "Quebec"
            },
            {
                "Mankota", "Saskatchewan"
            },
            {
                "Manning", "Alberta"
            },
            {
                "Mannville", "Alberta"
            },
            {
                "Manor", "Saskatchewan"
            },
            {
                "Manotick", "Ontario"
            },
            {
                "Manouane", "Quebec"
            },
            {
                "Manseau", "Quebec"
            },
            {
                "Mansonville", "Quebec"
            },
            {
                "Manyberries", "Alberta"
            },
            {
                "Maple", "Ontario"
            },
            {
                "Maple Creek", "Saskatchewan"
            },
            {
                "Maple Grove", "Quebec"
            },
            {
                "Maple Ridge", "British Columbia"
            },
            {
                "Marathon", "Ontario"
            },
            {
                "Marcelin", "Saskatchewan"
            },
            {
                "Margaree Forks", "Nova Scotia"
            },
            {
                "Margo", "Saskatchewan"
            },
            {
                "Maria", "Quebec"
            },
            {
                "Marieville", "Quebec"
            },
            {
                "Marion Bridge", "Nova Scotia"
            },
            {
                "Markdale", "Ontario"
            },
            {
                "Markham", "Ontario"
            },
            {
                "Markstay", "Ontario"
            },
            {
                "Marlboro", "Alberta"
            },
            {
                "Marmora", "Ontario"
            },
            {
                "Marquis", "Saskatchewan"
            },
            {
                "Marsden", "Saskatchewan"
            },
            {
                "Marsh Lake", "Yukon"
            },
            {
                "Marshall", "Saskatchewan"
            },
            {
                "Marsoui", "Quebec"
            },
            {
                "Marten Falls First Nation", "Ontario"
            },
            {
                "Marten River", "Ontario"
            },
            {
                "Martensville", "Saskatchewan"
            },
            {
                "Martintown", "Ontario"
            },
            {
                "Marwayne", "Alberta"
            },
            {
                "Maryfield", "Saskatchewan"
            },
            {
                "Marystown", "Newfoundland"
            },
            {
                "Mary`s Harbour", "Newfoundland"
            },
            {
                "Mascouche", "Quebec"
            },
            {
                "Maskinonge", "Quebec"
            },
            {
                "Masset", "British Columbia"
            },
            {
                "Massey", "Ontario"
            },
            {
                "Massey Drive", "Newfoundland"
            },
            {
                "Masson-Angers", "Quebec"
            },
            {
                "Massueville", "Quebec"
            },
            {
                "Mastigouche", "Quebec"
            },
            {
                "Matachewan", "Ontario"
            },
            {
                "Matagami", "Quebec"
            },
            {
                "Matane", "Quebec"
            },
            {
                "Matapedia", "Quebec"
            },
            {
                "Matheson", "Ontario"
            },
            {
                "Mattawa", "Ontario"
            },
            {
                "Mattice", "Ontario"
            },
            {
                "Maxville", "Ontario"
            },
            {
                "Mayerthorpe", "Alberta"
            },
            {
                "Maymont", "Saskatchewan"
            },
            {
                "Maynooth", "Ontario"
            },
            {
                "Mayo", "Yukon"
            },
            {
                "McAdam", "New Brunswick"
            },
            {
                "McAuley", "Manitoba"
            },
            {
                "McBride", "British Columbia"
            },
            {
                "McCreary", "Manitoba"
            },
            {
                "McDonalds Corners", "Ontario"
            },
            {
                "McGregor", "Ontario"
            },
            {
                "McIver`s", "Newfoundland"
            },
            {
                "McKellar", "Ontario"
            },
            {
                "McLeese Lake", "British Columbia"
            },
            {
                "McLennan", "Alberta"
            },
            {
                "McLeod Lake", "British Columbia"
            },
            {
                "Mcmasterville", "Quebec"
            },
            {
                "Meacham", "Saskatchewan"
            },
            {
                "Meadow Lake", "Saskatchewan"
            },
            {
                "Meaford", "Ontario"
            },
            {
                "Meander River", "Alberta"
            },
            {
                "Meath Park", "Saskatchewan"
            },
            {
                "Medicine Hat", "Alberta"
            },
            {
                "Meductic", "New Brunswick"
            },
            {
                "Melbourne", "Ontario"
            },
            {
                "Melbourne", "Quebec"
            },
            {
                "Melfort", "Saskatchewan"
            },
            {
                "Melita", "Manitoba"
            },
            {
                "Mellin", "Quebec"
            },
            {
                "Melocheville", "Quebec"
            },
            {
                "Melrose", "Nova Scotia"
            },
            {
                "Melville", "Saskatchewan"
            },
            {
                "Memramcook", "New Brunswick"
            },
            {
                "Meota", "Saskatchewan"
            },
            {
                "Mercier", "Quebec"
            },
            {
                "Merigomish", "Nova Scotia"
            },
            {
                "Merlin", "Ontario"
            },
            {
                "Merrickville", "Ontario"
            },
            {
                "Merritt", "British Columbia"
            },
            {
                "Metabetchouan", "Quebec"
            },
            {
                "Metcalfe", "Ontario"
            },
            {
                "Meteghan", "Nova Scotia"
            },
            {
                "Metis-sur-Mer", "Quebec"
            },
            {
                "Miami", "Manitoba"
            },
            {
                "Mica Creek", "British Columbia"
            },
            {
                "Midale", "Saskatchewan"
            },
            {
                "Middle Lake", "Saskatchewan"
            },
            {
                "Middleton", "Nova Scotia"
            },
            {
                "Midland", "Ontario"
            },
            {
                "Midway", "British Columbia"
            },
            {
                "Milden", "Saskatchewan"
            },
            {
                "Mildmay", "Ontario"
            },
            {
                "Milestone", "Saskatchewan"
            },
            {
                "Milford Bay", "Ontario"
            },
            {
                "Milk River", "Alberta"
            },
            {
                "Millbrook", "Ontario"
            },
            {
                "Millertown", "Newfoundland"
            },
            {
                "Millet", "Alberta"
            },
            {
                "Millhaven", "Ontario"
            },
            {
                "Milltown-Head of Bay D`Espoir", "Newfoundland"
            },
            {
                "Millville", "New Brunswick"
            },
            {
                "Milo", "Alberta"
            },
            {
                "Milton", "Ontario"
            },
            {
                "Milverton", "Ontario"
            },
            {
                "Minaki", "Ontario"
            },
            {
                "Minburn", "Alberta"
            },
            {
                "Mindemoya", "Ontario"
            },
            {
                "Minden", "Ontario"
            },
            {
                "Mine Centre", "Ontario"
            },
            {
                "Ming`s Bight", "Newfoundland"
            },
            {
                "Miniota", "Manitoba"
            },
            {
                "Minnedosa", "Manitoba"
            },
            {
                "Minto", "Manitoba"
            },
            {
                "Minto", "New Brunswick"
            },
            {
                "Minton", "Saskatchewan"
            },
            {
                "Mirabel", "Quebec"
            },
            {
                "Miramichi", "New Brunswick"
            },
            {
                "Mirror", "Alberta"
            },
            {
                "Miscou Island", "New Brunswick"
            },
            {
                "Missanabie", "Ontario"
            },
            {
                "Mission", "British Columbia"
            },
            {
                "Mississauga", "Ontario"
            },
            {
                "Mistassini", "Quebec"
            },
            {
                "Mistatim", "Saskatchewan"
            },
            {
                "Mitchell", "Ontario"
            },
            {
                "Mohawks Of The Bay of Quinte F", "Ontario"
            },
            {
                "Moisie", "Quebec"
            },
            {
                "Molanosa", "Saskatchewan"
            },
            {
                "Monastery", "Nova Scotia"
            },
            {
                "Moncton", "New Brunswick"
            },
            {
                "Monkstown", "Newfoundland"
            },
            {
                "Monkton", "Ontario"
            },
            {
                "Mont Bechervaise", "Quebec"
            },
            {
                "Mont St Grégoire", "Quebec"
            },
            {
                "Mont-Joli", "Quebec"
            },
            {
                "Mont-Laurier", "Quebec"
            },
            {
                "Mont-Louis", "Quebec"
            },
            {
                "Mont-Rolland", "Quebec"
            },
            {
                "Mont-Royal", "Quebec"
            },
            {
                "Mont-St-Hilaire", "Quebec"
            },
            {
                "Mont-St-Pierre", "Quebec"
            },
            {
                "Mont-Tremblant", "Quebec"
            },
            {
                "Montague", "Prince Edward Island"
            },
            {
                "Montebello", "Quebec"
            },
            {
                "Montmagny", "Quebec"
            },
            {
                "Montmartre", "Saskatchewan"
            },
            {
                "Montney", "British Columbia"
            },
            {
                "Montreal", "Quebec"
            },
            {
                "Montreal - Est", "Quebec"
            },
            {
                "Montréal - Nord", "Quebec"
            },
            {
                "Montréal - Ouest", "Quebec"
            },
            {
                "Moonbeam", "Ontario"
            },
            {
                "Moonstone", "Ontario"
            },
            {
                "Mooretown", "Ontario"
            },
            {
                "Moose Creek", "Ontario"
            },
            {
                "Moose Factory", "Ontario"
            },
            {
                "Moose Jaw", "Saskatchewan"
            },
            {
                "Moose Lake", "Manitoba"
            },
            {
                "Moosomin", "Saskatchewan"
            },
            {
                "Moosonee", "Ontario"
            },
            {
                "Morden", "Manitoba"
            },
            {
                "Morell", "Prince Edward Island"
            },
            {
                "Morin-Heights", "Quebec"
            },
            {
                "Morinville", "Alberta"
            },
            {
                "Morley", "Alberta"
            },
            {
                "Morrin", "Alberta"
            },
            {
                "Morris", "Manitoba"
            },
            {
                "Morrisburg", "Ontario"
            },
            {
                "Morse", "Saskatchewan"
            },
            {
                "Morson", "Ontario"
            },
            {
                "Mortlach", "Saskatchewan"
            },
            {
                "Mossbank", "Saskatchewan"
            },
            {
                "Mount Albert", "Ontario"
            },
            {
                "Mount Brydges", "Ontario"
            },
            {
                "Mount Carmel-Mitchells Brook-S", "Newfoundland"
            },
            {
                "Mount Forest", "Ontario"
            },
            {
                "Mount Hope", "Ontario"
            },
            {
                "Mount Moriah", "Newfoundland"
            },
            {
                "Mount Pearl", "Newfoundland"
            },
            {
                "Mount Pleasant", "Ontario"
            },
            {
                "Mount Stewart", "Prince Edward Island"
            },
            {
                "Mount Uniacke", "Nova Scotia"
            },
            {
                "Moyie", "British Columbia"
            },
            {
                "Mulgrave", "Nova Scotia"
            },
            {
                "Mulhurst", "Alberta"
            },
            {
                "Muncho Lake", "British Columbia"
            },
            {
                "Mundare", "Alberta"
            },
            {
                "Murdochville", "Quebec"
            },
            {
                "Murray River", "Prince Edward Island"
            },
            {
                "Musgrave Harbour", "Newfoundland"
            },
            {
                "Musgravetown", "Newfoundland"
            },
            {
                "Muskoka", "Ontario"
            },
            {
                "Muskoka Falls", "Ontario"
            },
            {
                "Muskrat Dam", "Ontario"
            },
            {
                "Muskrat Dam First Nation", "Ontario"
            },
            {
                "Musquodoboit Harbour", "Nova Scotia"
            },
            {
                "Mutton Bay", "Quebec"
            },
            {
                "Myrnam", "Alberta"
            },
            {
                "M`Chigeeng", "Ontario"
            },
            {
                "Nackawic", "New Brunswick"
            },
            {
                "Nahanni Butte", "Northwest Territories"
            },
            {
                "Naicam", "Saskatchewan"
            },
            {
                "Nain", "Newfoundland"
            },
            {
                "Nairn", "Ontario"
            },
            {
                "Naiscoutaing First Nation", "Ontario"
            },
            {
                "Nakina", "Ontario"
            },
            {
                "Nakusp", "British Columbia"
            },
            {
                "Namao", "Alberta"
            },
            {
                "Nampa", "Alberta"
            },
            {
                "Nanaimo", "British Columbia"
            },
            {
                "Nantes", "Quebec"
            },
            {
                "Nanticoke", "Ontario"
            },
            {
                "Nanton", "Alberta"
            },
            {
                "Napanee", "Ontario"
            },
            {
                "Napierville", "Quebec"
            },
            {
                "Naramata", "British Columbia"
            },
            {
                "Natashquan", "Quebec"
            },
            {
                "Navan", "Ontario"
            },
            {
                "Nedelec", "Quebec"
            },
            {
                "Neepawa", "Manitoba"
            },
            {
                "Neguac", "New Brunswick"
            },
            {
                "Neidpath", "Saskatchewan"
            },
            {
                "Neilburg", "Saskatchewan"
            },
            {
                "Nelson", "British Columbia"
            },
            {
                "Nelson House", "Manitoba"
            },
            {
                "Nepean", "Ontario"
            },
            {
                "Nephton", "Ontario"
            },
            {
                "Nestor Falls", "Ontario"
            },
            {
                "Neudorf", "Saskatchewan"
            },
            {
                "Neustadt", "Ontario"
            },
            {
                "Neuville", "Quebec"
            },
            {
                "Neville", "Saskatchewan"
            },
            {
                "New Aiyansh", "British Columbia"
            },
            {
                "New Carlisle", "Quebec"
            },
            {
                "New Dayton", "Alberta"
            },
            {
                "New Denmark", "New Brunswick"
            },
            {
                "New Denver", "British Columbia"
            },
            {
                "New Dundee", "Ontario"
            },
            {
                "New Germany", "Nova Scotia"
            },
            {
                "New Glasgow", "Nova Scotia"
            },
            {
                "New Glasgow", "Quebec"
            },
            {
                "New Hamburg", "Ontario"
            },
            {
                "New Harbour", "Newfoundland"
            },
            {
                "New Haven", "Prince Edward Island"
            },
            {
                "New Liskeard", "Ontario"
            },
            {
                "New London", "Prince Edward Island"
            },
            {
                "New Norway", "Alberta"
            },
            {
                "New Perlican", "Newfoundland"
            },
            {
                "New Richmond", "Quebec"
            },
            {
                "New Ross", "Nova Scotia"
            },
            {
                "New Sarepta", "Alberta"
            },
            {
                "New Tecumseth", "Ontario"
            },
            {
                "New Waterford", "Nova Scotia"
            },
            {
                "New Westminster", "British Columbia"
            },
            {
                "New-Wes-Valley", "Newfoundland"
            },
            {
                "Newbrook", "Alberta"
            },
            {
                "Newburgh", "Ontario"
            },
            {
                "Newcastle", "Ontario"
            },
            {
                "Newdale", "Manitoba"
            },
            {
                "Newmarket", "Ontario"
            },
            {
                "Newport", "Quebec"
            },
            {
                "Newtonville", "Ontario"
            },
            {
                "Niagara Falls", "Ontario"
            },
            {
                "Niagara-on-the-Lake", "Ontario"
            },
            {
                "Nickel Centre", "Ontario"
            },
            {
                "Nicolet", "Quebec"
            },
            {
                "Nimpo Lake", "British Columbia"
            },
            {
                "Nipawin", "Saskatchewan"
            },
            {
                "Nipigon", "Ontario"
            },
            {
                "Nipissing First Nation", "Ontario"
            },
            {
                "Nippers Harbour", "Newfoundland"
            },
            {
                "Nisku", "Alberta"
            },
            {
                "Niton Junction", "Alberta"
            },
            {
                "Niverville", "Manitoba"
            },
            {
                "Nobel", "Ontario"
            },
            {
                "Nobleford", "Alberta"
            },
            {
                "Nobleton", "Ontario"
            },
            {
                "Noel", "Nova Scotia"
            },
            {
                "Noelville", "Ontario"
            },
            {
                "Nokomis", "Saskatchewan"
            },
            {
                "Norbertville", "Quebec"
            },
            {
                "Nordegg", "Alberta"
            },
            {
                "Norman Wells", "Northwest Territories"
            },
            {
                "Normandin", "Quebec"
            },
            {
                "Norman`s Cove-Long Cove", "Newfoundland"
            },
            {
                "Normetal", "Quebec"
            },
            {
                "Norquay", "Saskatchewan"
            },
            {
                "Norris Arm", "Newfoundland"
            },
            {
                "North Augusta", "Ontario"
            },
            {
                "North Battleford", "Saskatchewan"
            },
            {
                "North Bay", "Ontario"
            },
            {
                "North Gower", "Ontario"
            },
            {
                "North Hatley", "Quebec"
            },
            {
                "North Portal", "Saskatchewan"
            },
            {
                "North Saanich", "British Columbia"
            },
            {
                "North Spirit Lake", "Ontario"
            },
            {
                "North Sydney", "Nova Scotia"
            },
            {
                "North Vancouver", "British Columbia"
            },
            {
                "North West River", "Newfoundland"
            },
            {
                "North York", "Ontario"
            },
            {
                "Northbrook", "Ontario"
            },
            {
                "Northern Arm", "Newfoundland"
            },
            {
                "Norton", "New Brunswick"
            },
            {
                "Norval", "Ontario"
            },
            {
                "Norway House", "Manitoba"
            },
            {
                "Norwich", "Ontario"
            },
            {
                "Norwood", "Ontario"
            },
            {
                "Notre Dame de Bonsecours", "Quebec"
            },
            {
                "Notre Dame de Lourdes", "Manitoba"
            },
            {
                "Notre Dame de Lourdes", "Quebec"
            },
            {
                "Notre Dame De L`Ile Perrot", "Quebec"
            },
            {
                "Notre Dame des Laurentides", "Quebec"
            },
            {
                "Notre Dame Des Prairies", "Quebec"
            },
            {
                "Notre Dame Du Portage", "Quebec"
            },
            {
                "Notre-Dame-de-la-Paix", "Quebec"
            },
            {
                "Notre-Dame-de-la-Salette", "Quebec"
            },
            {
                "Notre-Dame-de-Stanbridge", "Quebec"
            },
            {
                "Notre-Dame-du-Bon-Conseil", "Quebec"
            },
            {
                "Notre-Dame-du-Lac", "Quebec"
            },
            {
                "Notre-Dame-du-Laus", "Quebec"
            },
            {
                "Notre-Dame-du-Nord", "Quebec"
            },
            {
                "Nouvelle", "Quebec"
            },
            {
                "Oak Lake", "Manitoba"
            },
            {
                "Oak Ridges", "Ontario"
            },
            {
                "Oak River", "Manitoba"
            },
            {
                "Oakville", "Manitoba"
            },
            {
                "Oakville", "Ontario"
            },
            {
                "Oakwood", "Ontario"
            },
            {
                "Oba", "Ontario"
            },
            {
                "Ocean Falls", "British Columbia"
            },
            {
                "Ocean Park", "British Columbia"
            },
            {
                "Ochre River", "Manitoba"
            },
            {
                "Odessa", "Ontario"
            },
            {
                "Odessa", "Saskatchewan"
            },
            {
                "Ogema", "Saskatchewan"
            },
            {
                "Ogoki", "Ontario"
            },
            {
                "Ohsweken", "Ontario"
            },
            {
                "Oil Springs", "Ontario"
            },
            {
                "Ojibways of Hiawatha First Nat", "Ontario"
            },
            {
                "Ojibways of Walpole Island Fir", "Ontario"
            },
            {
                "Oka", "Quebec"
            },
            {
                "Okanagan Falls", "British Columbia"
            },
            {
                "Okotoks", "Alberta"
            },
            {
                "Old Crow", "Yukon"
            },
            {
                "Old Perlican", "Newfoundland"
            },
            {
                "Olds", "Alberta"
            },
            {
                "Oliver", "British Columbia"
            },
            {
                "Omemee", "Ontario"
            },
            {
                "Omerville", "Quebec"
            },
            {
                "Onaping Falls", "Ontario"
            },
            {
                "Oneida First Nation", "Ontario"
            },
            {
                "Onoway", "Alberta"
            },
            {
                "Opasatika", "Ontario"
            },
            {
                "Ophir", "Ontario"
            },
            {
                "Orangeville", "Ontario"
            },
            {
                "Orford", "Quebec"
            },
            {
                "Orillia", "Ontario"
            },
            {
                "Orleans", "Ontario"
            },
            {
                "Ormiston", "Saskatchewan"
            },
            {
                "Ormstown", "Quebec"
            },
            {
                "Oro", "Ontario"
            },
            {
                "Oromocto", "New Brunswick"
            },
            {
                "Orono", "Ontario"
            },
            {
                "Orrville", "Ontario"
            },
            {
                "Osgoode", "Ontario"
            },
            {
                "Oshawa", "Ontario"
            },
            {
                "Osler", "Saskatchewan"
            },
            {
                "Osoyoos", "British Columbia"
            },
            {
                "Ottawa", "Ontario"
            },
            {
                "Otterburn Park", "Quebec"
            },
            {
                "Otterville", "Ontario"
            },
            {
                "Outlook", "Saskatchewan"
            },
            {
                "Outremont", "Quebec"
            },
            {
                "Owen Sound", "Ontario"
            },
            {
                "Oxbow", "Saskatchewan"
            },
            {
                "Oxdrift", "Ontario"
            },
            {
                "Oxford", "Nova Scotia"
            },
            {
                "Oxford House", "Manitoba"
            },
            {
                "Oxford Mills", "Ontario"
            },
            {
                "Oyama", "British Columbia"
            },
            {
                "Oyen", "Alberta"
            },
            {
                "O`Leary", "Prince Edward Island"
            },
            {
                "Packs Harbour", "Newfoundland"
            },
            {
                "Pacquet", "Newfoundland"
            },
            {
                "Paddockwood", "Saskatchewan"
            },
            {
                "Paisley", "Ontario"
            },
            {
                "Pakenham", "Ontario"
            },
            {
                "Palgrave", "Ontario"
            },
            {
                "Palmarolle", "Quebec"
            },
            {
                "Palmer Rapids", "Ontario"
            },
            {
                "Palmerston", "Ontario"
            },
            {
                "Pangman", "Saskatchewan"
            },
            {
                "Papineauville", "Quebec"
            },
            {
                "Paquette Corner", "Ontario"
            },
            {
                "Paquetville", "New Brunswick"
            },
            {
                "Paradise", "Newfoundland"
            },
            {
                "Paradise Hill", "Saskatchewan"
            },
            {
                "Paradise River", "Newfoundland"
            },
            {
                "Paradise Valley", "Alberta"
            },
            {
                "Parent", "Quebec"
            },
            {
                "Parham", "Ontario"
            },
            {
                "Paris", "Ontario"
            },
            {
                "Parkhill", "Ontario"
            },
            {
                "Parksville", "British Columbia"
            },
            {
                "Parrsboro", "Nova Scotia"
            },
            {
                "Parry Sound", "Ontario"
            },
            {
                "Parson", "British Columbia"
            },
            {
                "Pasadena", "Newfoundland"
            },
            {
                "Pass Lake", "Ontario"
            },
            {
                "Patuanak", "Saskatchewan"
            },
            {
                "Paynton", "Saskatchewan"
            },
            {
                "Peace River", "Alberta"
            },
            {
                "Peachland", "British Columbia"
            },
            {
                "Peawanuck", "Ontario"
            },
            {
                "Peerless Lake", "Alberta"
            },
            {
                "Peers", "Alberta"
            },
            {
                "Pefferlaw", "Ontario"
            },
            {
                "Peggy`s Cove", "Nova Scotia"
            },
            {
                "Peguis", "Manitoba"
            },
            {
                "Pelee Island", "Ontario"
            },
            {
                "Pelham", "Ontario"
            },
            {
                "Pelican Narrows", "Saskatchewan"
            },
            {
                "Pelican Rapids", "Manitoba"
            },
            {
                "Pelly", "Saskatchewan"
            },
            {
                "Pelly Crossing", "Yukon"
            },
            {
                "Pemberton", "British Columbia"
            },
            {
                "Pembroke", "Ontario"
            },
            {
                "Penetanguishene", "Ontario"
            },
            {
                "Penhold", "Alberta"
            },
            {
                "Pennant", "Saskatchewan"
            },
            {
                "Pense", "Saskatchewan"
            },
            {
                "Penticton", "British Columbia"
            },
            {
                "Perce", "Quebec"
            },
            {
                "Perdue", "Saskatchewan"
            },
            {
                "Peribonka", "Quebec"
            },
            {
                "Perkins", "Quebec"
            },
            {
                "Perrault Falls", "Ontario"
            },
            {
                "Perth", "Ontario"
            },
            {
                "Perth-Andover", "New Brunswick"
            },
            {
                "Petawawa", "Ontario"
            },
            {
                "Peterborough", "Ontario"
            },
            {
                "Peterview", "Newfoundland"
            },
            {
                "Petit Rocher", "New Brunswick"
            },
            {
                "Petitcodiac", "New Brunswick"
            },
            {
                "Petite-Riviere-St-Francois", "Quebec"
            },
            {
                "Petrolia", "Ontario"
            },
            {
                "Petty Harbour-Maddox Cove", "Newfoundland"
            },
            {
                "Philipsburg", "Quebec"
            },
            {
                "Piapot", "Saskatchewan"
            },
            {
                "Pickering", "Ontario"
            },
            {
                "Pickle Lake", "Ontario"
            },
            {
                "Picton", "Ontario"
            },
            {
                "Pictou", "Nova Scotia"
            },
            {
                "Picture Butte", "Alberta"
            },
            {
                "Pierceland", "Saskatchewan"
            },
            {
                "Pierrefonds", "Quebec"
            },
            {
                "Pierreville", "Quebec"
            },
            {
                "Pikangikum First Nation", "Ontario"
            },
            {
                "Pikwitonei", "Manitoba"
            },
            {
                "Pilot Butte", "Saskatchewan"
            },
            {
                "Pilot Mound", "Manitoba"
            },
            {
                "Pinawa", "Manitoba"
            },
            {
                "Pincher Creek", "Alberta"
            },
            {
                "Pincourt", "Quebec"
            },
            {
                "Pine Dock", "Manitoba"
            },
            {
                "Pine Falls", "Manitoba"
            },
            {
                "Pine River", "Manitoba"
            },
            {
                "Pineal Lake", "Ontario"
            },
            {
                "Pinehouse", "Saskatchewan"
            },
            {
                "Piney", "Manitoba"
            },
            {
                "Pintendre", "Quebec"
            },
            {
                "Pitt Meadows", "British Columbia"
            },
            {
                "Placentia", "Newfoundland"
            },
            {
                "Plaisance", "Quebec"
            },
            {
                "Plamondon", "Alberta"
            },
            {
                "Plantagenet", "Ontario"
            },
            {
                "Plaster Rock", "New Brunswick"
            },
            {
                "Plate Cove East", "Newfoundland"
            },
            {
                "Plato", "Saskatchewan"
            },
            {
                "Plattsville", "Ontario"
            },
            {
                "Pleasant Park", "Ontario"
            },
            {
                "Plenty", "Saskatchewan"
            },
            {
                "Plessisville", "Quebec"
            },
            {
                "Plevna", "Ontario"
            },
            {
                "Plum Coulee", "Manitoba"
            },
            {
                "Plumas", "Manitoba"
            },
            {
                "Pohenegamook", "Quebec"
            },
            {
                "Point Grondine First Nation", "Ontario"
            },
            {
                "Point Leamington", "Newfoundland"
            },
            {
                "Point Pelee", "Ontario"
            },
            {
                "Pointe au Baril", "Ontario"
            },
            {
                "Pointe Aux Trembles", "Quebec"
            },
            {
                "Pointe du Bois", "Manitoba"
            },
            {
                "Pointe-a-la-Croix", "Quebec"
            },
            {
                "Pointe-au-Pere", "Quebec"
            },
            {
                "Pointe-aux-Outardes", "Quebec"
            },
            {
                "Pointe-Calumet", "Quebec"
            },
            {
                "Pointe-Claire", "Quebec"
            },
            {
                "Pointe-des-Cascades", "Quebec"
            },
            {
                "Pointe-des-Monts", "Quebec"
            },
            {
                "Pointe-Fortune", "Quebec"
            },
            {
                "Pointe-Lebel", "Quebec"
            },
            {
                "Ponoka", "Alberta"
            },
            {
                "Pont-Rouge", "Quebec"
            },
            {
                "Pont-Viau", "Quebec"
            },
            {
                "Ponteix", "Saskatchewan"
            },
            {
                "Pontiac", "Quebec"
            },
            {
                "Pool`s Cove", "Newfoundland"
            },
            {
                "Poplar River", "Manitoba"
            },
            {
                "Poplarfield", "Manitoba"
            },
            {
                "Porcupine Plain", "Saskatchewan"
            },
            {
                "Port Alberni", "British Columbia"
            },
            {
                "Port Alice", "British Columbia"
            },
            {
                "Port au Choix", "Newfoundland"
            },
            {
                "Port au Port West-Aguathuna-Fe", "Newfoundland"
            },
            {
                "Port Aux Basques", "Newfoundland"
            },
            {
                "Port Bickerton", "Nova Scotia"
            },
            {
                "Port Blandford", "Newfoundland"
            },
            {
                "Port Burwell", "Ontario"
            },
            {
                "Port Carling", "Ontario"
            },
            {
                "Port Clements", "British Columbia"
            },
            {
                "Port Colborne", "Ontario"
            },
            {
                "Port Coquitlam", "British Columbia"
            },
            {
                "Port Credit", "Ontario"
            },
            {
                "Port Cunnington", "Ontario"
            },
            {
                "Port Dover", "Ontario"
            },
            {
                "Port Dufferin", "Nova Scotia"
            },
            {
                "Port Edward", "British Columbia"
            },
            {
                "Port Elgin", "New Brunswick"
            },
            {
                "Port Elgin", "Ontario"
            },
            {
                "Port Franks", "Ontario"
            },
            {
                "Port Greville", "Nova Scotia"
            },
            {
                "Port Hardy", "British Columbia"
            },
            {
                "Port Hawkesbury", "Nova Scotia"
            },
            {
                "Port Hood", "Nova Scotia"
            },
            {
                "Port Hope", "Ontario"
            },
            {
                "Port Hope Simpson", "Newfoundland"
            },
            {
                "Port La Tour", "Nova Scotia"
            },
            {
                "Port Lambton", "Ontario"
            },
            {
                "Port Loring", "Ontario"
            },
            {
                "Port Maitland", "Nova Scotia"
            },
            {
                "Port McNeill", "British Columbia"
            },
            {
                "Port McNicoll", "Ontario"
            },
            {
                "Port Mellon", "British Columbia"
            },
            {
                "Port Moody", "British Columbia"
            },
            {
                "Port Morien", "Nova Scotia"
            },
            {
                "Port Mouton", "Nova Scotia"
            },
            {
                "Port Perry", "Ontario"
            },
            {
                "Port Renfrew", "British Columbia"
            },
            {
                "Port Rexton", "Newfoundland"
            },
            {
                "Port Robinson", "Ontario"
            },
            {
                "Port Rowan", "Ontario"
            },
            {
                "Port Saunders", "Newfoundland"
            },
            {
                "Port Stanley", "Ontario"
            },
            {
                "Port Sydney", "Ontario"
            },
            {
                "Port Union", "Newfoundland"
            },
            {
                "Port-Cartier", "Quebec"
            },
            {
                "Port-Daniel", "Quebec"
            },
            {
                "Port-Menier", "Quebec"
            },
            {
                "Portage la Prairie", "Manitoba"
            },
            {
                "Portage-du-Fort", "Quebec"
            },
            {
                "Portland", "Ontario"
            },
            {
                "Portneuf", "Quebec"
            },
            {
                "Portugal Cove-St. Philip`s", "Newfoundland"
            },
            {
                "Poste-de-la-Baleine", "Quebec"
            },
            {
                "Postville", "Newfoundland"
            },
            {
                "Pouce Coupe", "British Columbia"
            },
            {
                "Pouch Cove", "Newfoundland"
            },
            {
                "Powassan", "Ontario"
            },
            {
                "Powell River", "British Columbia"
            },
            {
                "Preeceville", "Saskatchewan"
            },
            {
                "Prelate", "Saskatchewan"
            },
            {
                "Prescott", "Ontario"
            },
            {
                "Prespatou", "British Columbia"
            },
            {
                "Preston", "Ontario"
            },
            {
                "Prevost", "Quebec"
            },
            {
                "Price", "Quebec"
            },
            {
                "Prince Albert", "Saskatchewan"
            },
            {
                "Prince George", "British Columbia"
            },
            {
                "Prince Rupert", "British Columbia"
            },
            {
                "Princeton", "British Columbia"
            },
            {
                "Princeton", "Newfoundland"
            },
            {
                "Princeton", "Ontario"
            },
            {
                "Princeville", "Quebec"
            },
            {
                "Prophet River", "British Columbia"
            },
            {
                "Provost", "Alberta"
            },
            {
                "Prud`homme", "Saskatchewan"
            },
            {
                "Pubnico", "Nova Scotia"
            },
            {
                "Puce", "Ontario"
            },
            {
                "Pugwash", "Nova Scotia"
            },
            {
                "Punnichy", "Saskatchewan"
            },
            {
                "Puvirnituq", "Quebec"
            },
            {
                "Quadra Island", "British Columbia"
            },
            {
                "Qualicum Beach", "British Columbia"
            },
            {
                "Quebec", "Quebec"
            },
            {
                "Queen Charlotte", "British Columbia"
            },
            {
                "Queensport", "Nova Scotia"
            },
            {
                "Queenston", "Ontario"
            },
            {
                "Queensville", "Ontario"
            },
            {
                "Quesnel", "British Columbia"
            },
            {
                "Quill Lake", "Saskatchewan"
            },
            {
                "Quispamsis", "New Brunswick"
            },
            {
                "Quyon", "Quebec"
            },
            {
                "Qu`Appelle", "Saskatchewan"
            },
            {
                "Rabbit Lake", "Saskatchewan"
            },
            {
                "Radisson", "Quebec"
            },
            {
                "Radisson", "Saskatchewan"
            },
            {
                "Radium Hot Springs", "British Columbia"
            },
            {
                "Radville", "Saskatchewan"
            },
            {
                "Radway", "Alberta"
            },
            {
                "Rae", "Northwest Territories"
            },
            {
                "Rae Lakes", "Northwest Territories"
            },
            {
                "Rainbow Lake", "Alberta"
            },
            {
                "Rainy Lake First Nation", "Ontario"
            },
            {
                "Rainy River", "Ontario"
            },
            {
                "Raith", "Ontario"
            },
            {
                "Raleigh", "Newfoundland"
            },
            {
                "Ralston", "Alberta"
            },
            {
                "Ramea", "Newfoundland"
            },
            {
                "Ramore", "Ontario"
            },
            {
                "Rankin Inlet", "Nunavut"
            },
            {
                "Rapid City", "Manitoba"
            },
            {
                "Rathwell", "Manitoba"
            },
            {
                "Rawdon", "Quebec"
            },
            {
                "Raymond", "Alberta"
            },
            {
                "Raymore", "Saskatchewan"
            },
            {
                "Rayside-Balfour", "Ontario"
            },
            {
                "Red Bank", "New Brunswick"
            },
            {
                "Red Bay", "Newfoundland"
            },
            {
                "Red Deer", "Alberta"
            },
            {
                "Red Lake", "Ontario"
            },
            {
                "Red Rock", "British Columbia"
            },
            {
                "Red Rock", "Ontario"
            },
            {
                "Red Sucker Lake", "Manitoba"
            },
            {
                "Redbridge", "Ontario"
            },
            {
                "Redcliff", "Alberta"
            },
            {
                "Redditt", "Ontario"
            },
            {
                "Redvers", "Saskatchewan"
            },
            {
                "Redwater", "Alberta"
            },
            {
                "Reefs Harbour", "Newfoundland"
            },
            {
                "Regina", "Saskatchewan"
            },
            {
                "Regina Beach", "Saskatchewan"
            },
            {
                "Remigny", "Quebec"
            },
            {
                "Rencontre East", "Newfoundland"
            },
            {
                "Renfrew", "Ontario"
            },
            {
                "Rennie", "Manitoba"
            },
            {
                "Repentigny", "Quebec"
            },
            {
                "Réserve faunique de Rimouski", "Quebec"
            },
            {
                "Réserve faunique la Vérendrye", "Quebec"
            },
            {
                "Réserves fauniques de Matane e", "Quebec"
            },
            {
                "Resolute", "Nunavut"
            },
            {
                "Reston", "Manitoba"
            },
            {
                "Restoule", "Ontario"
            },
            {
                "Revelstoke", "British Columbia"
            },
            {
                "Rhein", "Saskatchewan"
            },
            {
                "Riceton", "Saskatchewan"
            },
            {
                "Richelieu", "Quebec"
            },
            {
                "Richibucto", "New Brunswick"
            },
            {
                "Richmond", "British Columbia"
            },
            {
                "Richmond", "Ontario"
            },
            {
                "Richmond", "Quebec"
            },
            {
                "Richmond Hill", "Ontario"
            },
            {
                "Richmound", "Saskatchewan"
            },
            {
                "Ridgedale", "Saskatchewan"
            },
            {
                "Ridgetown", "Ontario"
            },
            {
                "Ridgeway", "Ontario"
            },
            {
                "Rigaud", "Quebec"
            },
            {
                "Rigolet", "Newfoundland"
            },
            {
                "Rimbey", "Alberta"
            },
            {
                "Rimouski", "Quebec"
            },
            {
                "Rimouski-Est", "Quebec"
            },
            {
                "Riondel", "British Columbia"
            },
            {
                "Ripley", "Ontario"
            },
            {
                "Ripon", "Quebec"
            },
            {
                "Riske Creek", "British Columbia"
            },
            {
                "River Hebert", "Nova Scotia"
            },
            {
                "River John", "Nova Scotia"
            },
            {
                "River of Ponds", "Newfoundland"
            },
            {
                "Riverhurst", "Saskatchewan"
            },
            {
                "Riverport", "Nova Scotia"
            },
            {
                "Rivers", "Manitoba"
            },
            {
                "Riverton", "Manitoba"
            },
            {
                "Riverview", "New Brunswick"
            },
            {
                "Riviere-a-Pierre", "Quebec"
            },
            {
                "Riviere-au-Renard", "Quebec"
            },
            {
                "Riviere-au-Tonnerre", "Quebec"
            },
            {
                "Riviere-Beaudette", "Quebec"
            },
            {
                "Riviere-Bleue", "Quebec"
            },
            {
                "Riviere-du-Loup", "Quebec"
            },
            {
                "Riviere-Heva", "Quebec"
            },
            {
                "Riviere-St-Jean", "Quebec"
            },
            {
                "Robb", "Alberta"
            },
            {
                "Robertsonville", "Quebec"
            },
            {
                "Robert`s Arm", "Newfoundland"
            },
            {
                "Roberval", "Quebec"
            },
            {
                "Roblin", "Manitoba"
            },
            {
                "Rocanville", "Saskatchewan"
            },
            {
                "Rochebaucourt", "Quebec"
            },
            {
                "Rochester", "Alberta"
            },
            {
                "Rock Creek", "British Columbia"
            },
            {
                "Rock Forest", "Quebec"
            },
            {
                "Rockglen", "Saskatchewan"
            },
            {
                "Rockland", "Ontario"
            },
            {
                "Rockwood", "Ontario"
            },
            {
                "Rocky Harbour", "Newfoundland"
            },
            {
                "Rocky Mountain House", "Alberta"
            },
            {
                "Rockyford", "Alberta"
            },
            {
                "Roddickton", "Newfoundland"
            },
            {
                "Rodney", "Ontario"
            },
            {
                "Rogersville", "New Brunswick"
            },
            {
                "Roland", "Manitoba"
            },
            {
                "Rolla", "British Columbia"
            },
            {
                "Rollet", "Quebec"
            },
            {
                "Rolling Hills", "Alberta"
            },
            {
                "Rolphton", "Ontario"
            },
            {
                "Rondeau", "Ontario"
            },
            {
                "Rorketon", "Manitoba"
            },
            {
                "Rosalind", "Alberta"
            },
            {
                "Rose Blanche-Harbour Le Cou", "Newfoundland"
            },
            {
                "Rose Valley", "Saskatchewan"
            },
            {
                "Rosebud", "Alberta"
            },
            {
                "Rosemere", "Quebec"
            },
            {
                "Roseneath", "Ontario"
            },
            {
                "Rosetown", "Saskatchewan"
            },
            {
                "Ross River", "Yukon"
            },
            {
                "Rossburn", "Manitoba"
            },
            {
                "Rosseau", "Ontario"
            },
            {
                "Rossland", "British Columbia"
            },
            {
                "Rosthern", "Saskatchewan"
            },
            {
                "Rothesay", "New Brunswick"
            },
            {
                "Rougemont", "Quebec"
            },
            {
                "Rouleau", "Saskatchewan"
            },
            {
                "Rouyn-Noranda", "Quebec"
            },
            {
                "Roxboro", "Quebec"
            },
            {
                "Roxton Falls", "Quebec"
            },
            {
                "Roxton Pond", "Quebec"
            },
            {
                "Rumsey", "Alberta"
            },
            {
                "Rushoon", "Newfoundland"
            },
            {
                "Russell", "Manitoba"
            },
            {
                "Russell", "Ontario"
            },
            {
                "Rusticoville", "Prince Edward Island"
            },
            {
                "Ruthven", "Ontario"
            },
            {
                "Rycroft", "Alberta"
            },
            {
                "Ryley", "Alberta"
            },
            {
                "Saanich", "British Columbia"
            },
            {
                "Sabrevois", "Quebec"
            },
            {
                "Sachigo First Nation Reserve 1", "Ontario"
            },
            {
                "Sackville", "New Brunswick"
            },
            {
                "Sacre Coeur", "Quebec"
            },
            {
                "Saint Alexandre D`Iberville", "Quebec"
            },
            {
                "Saint Alphonse de Granby", "Quebec"
            },
            {
                "Saint Amable", "Quebec"
            },
            {
                "Saint Andrews", "New Brunswick"
            },
            {
                "Saint Antoine Des Laurentides", "Quebec"
            },
            {
                "Saint Antoine Sur Richelieu", "Quebec"
            },
            {
                "Saint Antonin", "Quebec"
            },
            {
                "Saint Athanase", "Quebec"
            },
            {
                "Saint Calixte", "Quebec"
            },
            {
                "Saint Charles Borromee", "Quebec"
            },
            {
                "Saint Charles Sur Richelieu", "Quebec"
            },
            {
                "Saint Christophe D`Arthabaska", "Quebec"
            },
            {
                "Saint Clair Beach", "Ontario"
            },
            {
                "Saint Colomban", "Quebec"
            },
            {
                "Saint Denis De Brompton", "Quebec"
            },
            {
                "Saint Denis Sur Richelieu", "Quebec"
            },
            {
                "Saint Esprit", "Quebec"
            },
            {
                "Saint Etienne de Beauharnois", "Quebec"
            },
            {
                "Saint Etienne de Lauzon", "Quebec"
            },
            {
                "Saint Gerard Majella", "Quebec"
            },
            {
                "Saint Isidore de la Prairie", "Quebec"
            },
            {
                "Saint Jean Baptiste", "Quebec"
            },
            {
                "Saint Jean D`Orleans", "Quebec"
            },
            {
                "Saint Joachim", "Quebec"
            },
            {
                "Saint John", "New Brunswick"
            },
            {
                "Saint Joseph De La Pointe De L", "Quebec"
            },
            {
                "Saint Laurent D`Orleans", "Quebec"
            },
            {
                "Saint Lazare De Vaudreuil", "Quebec"
            },
            {
                "Saint Lin Laurentides", "Quebec"
            },
            {
                "Saint Marc Sur Richelieu", "Quebec"
            },
            {
                "Saint Mathias Sur Richelieu", "Quebec"
            },
            {
                "Saint Mathieu de Beloeil", "Quebec"
            },
            {
                "Saint Mathieu de la Prairie", "Quebec"
            },
            {
                "Saint Maurice", "Quebec"
            },
            {
                "Saint Norbert D`Arthabaska", "Quebec"
            },
            {
                "Saint Paul D`Industrie", "Quebec"
            },
            {
                "Saint Philippe", "Quebec"
            },
            {
                "Saint Pierre D`Orleans", "Quebec"
            },
            {
                "Saint Robert", "Quebec"
            },
            {
                "Saint Roch De L`Achigan", "Quebec"
            },
            {
                "Saint Roch De Richelieu", "Quebec"
            },
            {
                "Saint Sulpice", "Quebec"
            },
            {
                "Saint Thomas", "Quebec"
            },
            {
                "Saint Urbain Premier", "Quebec"
            },
            {
                "Saint Valere", "Quebec"
            },
            {
                "Saint Victoire de Sorel", "Quebec"
            },
            {
                "Saint-Alexis-de-Montcalm", "Quebec"
            },
            {
                "Saint-Côme", "Quebec"
            },
            {
                "Saint-Donat", "Quebec"
            },
            {
                "Saint-Élie", "Quebec"
            },
            {
                "Saint-Élie-d`Orford", "Quebec"
            },
            {
                "Saint-Ferdinand", "Quebec"
            },
            {
                "Saint-Ferréol-les-neiges", "Quebec"
            },
            {
                "Saint-Hubert", "Quebec"
            },
            {
                "Saint-Hyacinthe", "Quebec"
            },
            {
                "Saint-Michel-des-Saints", "Quebec"
            },
            {
                "Sainte Angele De Monnoir", "Quebec"
            },
            {
                "Sainte Ann De Sorel", "Quebec"
            },
            {
                "Sainte Brigide D`Iberville", "Quebec"
            },
            {
                "Sainte Cecile De Milton", "Quebec"
            },
            {
                "Sainte Dorotheé", "Quebec"
            },
            {
                "Sainte Famille", "Quebec"
            },
            {
                "Sainte Marie Salome", "Quebec"
            },
            {
                "Sainte Marthe Du Cap", "Quebec"
            },
            {
                "Sainte Sophie", "Quebec"
            },
            {
                "Sainte Therese De Blainville", "Quebec"
            },
            {
                "Salaberry-de-Valleyfield", "Quebec"
            },
            {
                "Salem", "Ontario"
            },
            {
                "Salisbury", "New Brunswick"
            },
            {
                "Salluit", "Quebec"
            },
            {
                "Salmo", "British Columbia"
            },
            {
                "Salmon Arm", "British Columbia"
            },
            {
                "Salmon Cove", "Newfoundland"
            },
            {
                "Salmon Valley", "British Columbia"
            },
            {
                "Salt Springs", "Nova Scotia"
            },
            {
                "Saltcoats", "Saskatchewan"
            },
            {
                "Salvage", "Newfoundland"
            },
            {
                "Sandspit", "British Columbia"
            },
            {
                "Sandwich", "Ontario"
            },
            {
                "Sandy Bay", "Saskatchewan"
            },
            {
                "Sandy Cove Acres", "Ontario"
            },
            {
                "Sandy Lake", "Manitoba"
            },
            {
                "Sandy Lake", "Ontario"
            },
            {
                "Sandy Lake First Nation", "Ontario"
            },
            {
                "Sanford", "Manitoba"
            },
            {
                "Sangudo", "Alberta"
            },
            {
                "Sanmaur", "Quebec"
            },
            {
                "Sapawe", "Ontario"
            },
            {
                "Sarnia", "Ontario"
            },
            {
                "Saskatchewan River Crossing", "Alberta"
            },
            {
                "Saskatoon", "Saskatchewan"
            },
            {
                "Sauble Beach", "Ontario"
            },
            {
                "Saugeen First Nation", "Ontario"
            },
            {
                "Saulnierville", "Nova Scotia"
            },
            {
                "Sault Ste. Marie", "Ontario"
            },
            {
                "Sault-au-Mouton", "Quebec"
            },
            {
                "Savant Lake", "Ontario"
            },
            {
                "Savona", "British Columbia"
            },
            {
                "Sawyerville", "Quebec"
            },
            {
                "Sayabec", "Quebec"
            },
            {
                "Sayward", "British Columbia"
            },
            {
                "Scarborough", "Ontario"
            },
            {
                "Sceptre", "Saskatchewan"
            },
            {
                "Schefferville", "Quebec"
            },
            {
                "Schomberg", "Ontario"
            },
            {
                "Schreiber", "Ontario"
            },
            {
                "Schuler", "Alberta"
            },
            {
                "Scotland", "Ontario"
            },
            {
                "Scotstown", "Quebec"
            },
            {
                "Scott", "Saskatchewan"
            },
            {
                "Seaforth", "Ontario"
            },
            {
                "Seal Cove", "Newfoundland"
            },
            {
                "Searchmont", "Ontario"
            },
            {
                "Seba Beach", "Alberta"
            },
            {
                "Sebright", "Ontario"
            },
            {
                "Sebringville", "Ontario"
            },
            {
                "Sechelt", "British Columbia"
            },
            {
                "Sedgewick", "Alberta"
            },
            {
                "Sedley", "Saskatchewan"
            },
            {
                "Seeleys Bay", "Ontario"
            },
            {
                "Selby", "Ontario"
            },
            {
                "Seldom-Little Seldom", "Newfoundland"
            },
            {
                "Selkirk", "Manitoba"
            },
            {
                "Selkirk", "Ontario"
            },
            {
                "Semans", "Saskatchewan"
            },
            {
                "Senneterre", "Quebec"
            },
            {
                "Senneville", "Quebec"
            },
            {
                "Sept-Iles", "Quebec"
            },
            {
                "Serpent River First Nation", "Ontario"
            },
            {
                "Seven Persons", "Alberta"
            },
            {
                "Severn Bridge", "Ontario"
            },
            {
                "Sexsmith", "Alberta"
            },
            {
                "Shakespeare", "Ontario"
            },
            {
                "Shalalth", "British Columbia"
            },
            {
                "Shamattawa", "Manitoba"
            },
            {
                "Shannonville", "Ontario"
            },
            {
                "Sharbot Lake", "Ontario"
            },
            {
                "Shaunavon", "Saskatchewan"
            },
            {
                "Shawanaga First Nation", "Ontario"
            },
            {
                "Shawbridge", "Quebec"
            },
            {
                "Shawinigan", "Quebec"
            },
            {
                "Shawinigan-Sud", "Quebec"
            },
            {
                "Shawville", "Quebec"
            },
            {
                "Shebandowan", "Ontario"
            },
            {
                "Shedden", "Ontario"
            },
            {
                "Shediac", "New Brunswick"
            },
            {
                "Shefford", "Quebec"
            },
            {
                "Sheho", "Saskatchewan"
            },
            {
                "Shelburne", "Nova Scotia"
            },
            {
                "Shelburne", "Ontario"
            },
            {
                "Shell Lake", "Saskatchewan"
            },
            {
                "Shellbrook", "Saskatchewan"
            },
            {
                "Sherbrooke", "Nova Scotia"
            },
            {
                "Sherbrooke", "Quebec"
            },
            {
                "Sherwood Park", "Alberta"
            },
            {
                "Shigawake", "Quebec"
            },
            {
                "Shilo", "Manitoba"
            },
            {
                "Shippagan", "New Brunswick"
            },
            {
                "Shipshaw", "Quebec"
            },
            {
                "Shoal Lake", "Manitoba"
            },
            {
                "Shubenacadie", "Nova Scotia"
            },
            {
                "Sibbald", "Alberta"
            },
            {
                "Sicamous", "British Columbia"
            },
            {
                "Sidney", "British Columbia"
            },
            {
                "Sidney", "Manitoba"
            },
            {
                "Sifton", "Manitoba"
            },
            {
                "Sillery", "Quebec"
            },
            {
                "Silver Valley", "Alberta"
            },
            {
                "Silver Water", "Ontario"
            },
            {
                "Simcoe", "Ontario"
            },
            {
                "Simpson", "Saskatchewan"
            },
            {
                "Sintaluta", "Saskatchewan"
            },
            {
                "Sioux Lookout", "Ontario"
            },
            {
                "Sioux Narrows", "Ontario"
            },
            {
                "Six Nations of the Grand River", "Ontario"
            },
            {
                "Skookumchuck", "British Columbia"
            },
            {
                "Slave Lake", "Alberta"
            },
            {
                "Slocan", "British Columbia"
            },
            {
                "Small Point-Broad Cove-Blackhe", "Newfoundland"
            },
            {
                "Smeaton", "Saskatchewan"
            },
            {
                "Smiley", "Saskatchewan"
            },
            {
                "Smith", "Alberta"
            },
            {
                "Smithers", "British Columbia"
            },
            {
                "Smiths Falls", "Ontario"
            },
            {
                "Smithville", "Ontario"
            },
            {
                "Smoky Lake", "Alberta"
            },
            {
                "Smooth Rock Falls", "Ontario"
            },
            {
                "Snelgrove", "Ontario"
            },
            {
                "Snow Lake", "Manitoba"
            },
            {
                "Snowflake", "Manitoba"
            },
            {
                "Sointula", "British Columbia"
            },
            {
                "Sombra", "Ontario"
            },
            {
                "Somerset", "Manitoba"
            },
            {
                "Sooke", "British Columbia"
            },
            {
                "Sorel-Tracy", "Quebec"
            },
            {
                "Sorrento", "British Columbia"
            },
            {
                "Souris", "Manitoba"
            },
            {
                "Souris", "Prince Edward Island"
            },
            {
                "South Brook", "Newfoundland"
            },
            {
                "South Indian Lake", "Manitoba"
            },
            {
                "South Lake", "Prince Edward Island"
            },
            {
                "South Mountain", "Ontario"
            },
            {
                "South River", "Newfoundland"
            },
            {
                "South River", "Ontario"
            },
            {
                "South Slocan", "British Columbia"
            },
            {
                "Southampton", "Nova Scotia"
            },
            {
                "Southampton", "Ontario"
            },
            {
                "Southend", "Saskatchewan"
            },
            {
                "Southern Harbour", "Newfoundland"
            },
            {
                "Southey", "Saskatchewan"
            },
            {
                "Spalding", "Saskatchewan"
            },
            {
                "Spaniard`s Bay", "Newfoundland"
            },
            {
                "Spanish", "Ontario"
            },
            {
                "Sparta", "Ontario"
            },
            {
                "Sparwood", "British Columbia"
            },
            {
                "Speers", "Saskatchewan"
            },
            {
                "Spencerville", "Ontario"
            },
            {
                "Spences Bridge", "British Columbia"
            },
            {
                "Sperling", "Manitoba"
            },
            {
                "Spillimacheen", "British Columbia"
            },
            {
                "Spirit River", "Alberta"
            },
            {
                "Spiritwood", "Saskatchewan"
            },
            {
                "Split Lake", "Manitoba"
            },
            {
                "Spotted Island", "Newfoundland"
            },
            {
                "Sprague", "Manitoba"
            },
            {
                "Springdale", "Newfoundland"
            },
            {
                "Springfield", "New Brunswick"
            },
            {
                "Springfield", "Nova Scotia"
            },
            {
                "Springhill", "Nova Scotia"
            },
            {
                "Springside", "Saskatchewan"
            },
            {
                "Spruce Grove", "Alberta"
            },
            {
                "Spruce View", "Alberta"
            },
            {
                "Sprucedale", "Ontario"
            },
            {
                "Spy Hill", "Saskatchewan"
            },
            {
                "Squamish", "British Columbia"
            },
            {
                "Squatec", "Quebec"
            },
            {
                "St-Adelphe", "Quebec"
            },
            {
                "St-Adolphe-de-Dudswell", "Quebec"
            },
            {
                "St-Adolphe-d`Howard", "Quebec"
            },
            {
                "St-Agapit", "Quebec"
            },
            {
                "St-Aime", "Quebec"
            },
            {
                "St-Albert", "Quebec"
            },
            {
                "St-Alexandre-de-Kamouraska", "Quebec"
            },
            {
                "St-Alexis-de-Matapedia", "Quebec"
            },
            {
                "St-Alexis-des-Monts", "Quebec"
            },
            {
                "St-Alphonse-Rodriguez", "Quebec"
            },
            {
                "St-Andre", "Quebec"
            },
            {
                "St-Andre-Avellin", "Quebec"
            },
            {
                "St-Andre-du-Lac-St-Jean", "Quebec"
            },
            {
                "St-Andre-Est", "Quebec"
            },
            {
                "St-Anselme", "Quebec"
            },
            {
                "St-Antoine", "New Brunswick"
            },
            {
                "St-Antoine", "Quebec"
            },
            {
                "St-Antoine-de-Tilly", "Quebec"
            },
            {
                "St-Apollinaire", "Quebec"
            },
            {
                "St-Augustin-de-Desmaures", "Quebec"
            },
            {
                "St-Barnabe", "Quebec"
            },
            {
                "St-Barthelemy", "Quebec"
            },
            {
                "St-Basile", "New Brunswick"
            },
            {
                "St-Basile-le-Grand", "Quebec"
            },
            {
                "St-Basile-Sud", "Quebec"
            },
            {
                "St-Blaise-sur-Richelieu", "Quebec"
            },
            {
                "St-Boniface-de-Shawinigan", "Quebec"
            },
            {
                "St-Bruno", "Quebec"
            },
            {
                "St-Bruno-de-Montarville", "Quebec"
            },
            {
                "St-Calixte-de-Kilkenny", "Quebec"
            },
            {
                "St-Casimir", "Quebec"
            },
            {
                "St-Celestin", "Quebec"
            },
            {
                "St-Cesaire", "Quebec"
            },
            {
                "St-Charles-de-Bellechasse", "Quebec"
            },
            {
                "St-Chrysostome", "Quebec"
            },
            {
                "St-Clet", "Quebec"
            },
            {
                "St-Constant", "Quebec"
            },
            {
                "St-Cyrille-de-Wendover", "Quebec"
            },
            {
                "St-Damase", "Quebec"
            },
            {
                "St-Damien-de-Buckland", "Quebec"
            },
            {
                "St-Denis", "Quebec"
            },
            {
                "St-Edouard-de-Lotbiniere", "Quebec"
            },
            {
                "St-Eleuthere", "Quebec"
            },
            {
                "St-Emile", "Quebec"
            },
            {
                "St-Emile-de-Suffolk", "Quebec"
            },
            {
                "St-Ephrem-de-Beauce", "Quebec"
            },
            {
                "St-Ephrem-de-Tring", "Quebec"
            },
            {
                "St-Eugene", "Ontario"
            },
            {
                "St-Eugene-de-Guigues", "Quebec"
            },
            {
                "St-Eustache", "Quebec"
            },
            {
                "St-Fabien-de-Panet", "Quebec"
            },
            {
                "St-Felicien", "Quebec"
            },
            {
                "St-Felix-de-Kingsey", "Quebec"
            },
            {
                "St-Felix-de-Valois", "Quebec"
            },
            {
                "St-Fidele-de-Mont-Murray", "Quebec"
            },
            {
                "St-Flavien", "Quebec"
            },
            {
                "St-Francois-du-Lac", "Quebec"
            },
            {
                "St-Fulgence", "Quebec"
            },
            {
                "St-Gabriel", "Quebec"
            },
            {
                "St-Gabriel-de-Brandon", "Quebec"
            },
            {
                "St-Gedeon", "Quebec"
            },
            {
                "St-Georges", "Quebec"
            },
            {
                "St-Georges-de-Beauce", "Quebec"
            },
            {
                "St-Georges-de-Cacouna", "Quebec"
            },
            {
                "St-Gerard", "Quebec"
            },
            {
                "St-Germain-de-Grantham", "Quebec"
            },
            {
                "St-Gregoire-de-Greenlay", "Quebec"
            },
            {
                "St-Guillaume", "Quebec"
            },
            {
                "St-Hilarion", "Quebec"
            },
            {
                "St-Hippolyte", "Quebec"
            },
            {
                "St-Honore-de-Beauce", "Quebec"
            },
            {
                "St-Honore-de-Chicoutimi", "Quebec"
            },
            {
                "St-Hugues", "Quebec"
            },
            {
                "St-Irenee", "Quebec"
            },
            {
                "St-Isidore", "New Brunswick"
            },
            {
                "St-Jacques", "Quebec"
            },
            {
                "St-Jean-Chrysostome", "Quebec"
            },
            {
                "St-Jean-de-Dieu", "Quebec"
            },
            {
                "St-Jean-de-Matha", "Quebec"
            },
            {
                "St-Jean-Port-Joli", "Quebec"
            },
            {
                "St-Jean-sur-Richelieu", "Quebec"
            },
            {
                "St-Jerome", "Quebec"
            },
            {
                "St-Joseph-de-Beauce", "Quebec"
            },
            {
                "St-Joseph-de-la-Rive", "Quebec"
            },
            {
                "St-Joseph-de-Sorel", "Quebec"
            },
            {
                "St-Jovite", "Quebec"
            },
            {
                "St-Jude", "Quebec"
            },
            {
                "St-Just-de-Bretenieres", "Quebec"
            },
            {
                "St-Lambert", "Quebec"
            },
            {
                "St-Lambert-de-Lauzon", "Quebec"
            },
            {
                "St-Laurent", "Quebec"
            },
            {
                "St-Leon-le-Grand", "Quebec"
            },
            {
                "St-Leonard", "Quebec"
            },
            {
                "St-Leonard-d`Aston", "Quebec"
            },
            {
                "St-Liboire", "Quebec"
            },
            {
                "St-Lin", "Quebec"
            },
            {
                "St-Louis de Kent", "New Brunswick"
            },
            {
                "St-Louis-de-France", "Quebec"
            },
            {
                "St-Luc", "Quebec"
            },
            {
                "St-Ludger", "Quebec"
            },
            {
                "St-Magloire", "Quebec"
            },
            {
                "St-Malachie", "Quebec"
            },
            {
                "St-Malo", "Quebec"
            },
            {
                "St-Marc-des-Carrieres", "Quebec"
            },
            {
                "St-Methode-de-Frontenac", "Quebec"
            },
            {
                "St-Michel-de-Bellechasse", "Quebec"
            },
            {
                "St-Moose", "Quebec"
            },
            {
                "St-Nazaire-d`Acton", "Quebec"
            },
            {
                "St-Nicolas", "Quebec"
            },
            {
                "St-Noel", "Quebec"
            },
            {
                "St-Odilon-de-Cranbourne", "Quebec"
            },
            {
                "St-Ours", "Quebec"
            },
            {
                "St-Pacome", "Quebec"
            },
            {
                "St-Pamphile", "Quebec"
            },
            {
                "St-Pascal", "Quebec"
            },
            {
                "St-Patrice-de-Beaurivage", "Quebec"
            },
            {
                "St-Paul-de-Montminy", "Quebec"
            },
            {
                "St-Paul-d`Abbotsford", "Quebec"
            },
            {
                "St-Paulin", "Quebec"
            },
            {
                "St-Philippe-de-Neri", "Quebec"
            },
            {
                "St-Pie", "Quebec"
            },
            {
                "St-Pie-de-Guire", "Quebec"
            },
            {
                "St-Pierre", "Quebec"
            },
            {
                "St-Pierre-de-Wakefield", "Quebec"
            },
            {
                "St-Pierre-Jolys", "Manitoba"
            },
            {
                "St-Pierre-les-Becquets", "Quebec"
            },
            {
                "St-Polycarpe", "Quebec"
            },
            {
                "St-Prime", "Quebec"
            },
            {
                "St-Prosper-de-Dorchester", "Quebec"
            },
            {
                "St-Quentin", "New Brunswick"
            },
            {
                "St-Raymond", "Quebec"
            },
            {
                "St-Redempteur", "Quebec"
            },
            {
                "St-Remi", "Quebec"
            },
            {
                "St-Rene-de-Matane", "Quebec"
            },
            {
                "St-Roch-de-Mekinac", "Quebec"
            },
            {
                "St-Roch-des-Aulnaies", "Quebec"
            },
            {
                "St-Romuald", "Quebec"
            },
            {
                "St-Sauveur", "Quebec"
            },
            {
                "St-Sauveur-des-Monts", "Quebec"
            },
            {
                "St-Simeon", "Quebec"
            },
            {
                "St-Simon-de-Bagot", "Quebec"
            },
            {
                "St-Simon-de-Rimouski", "Quebec"
            },
            {
                "St-Sylvere", "Quebec"
            },
            {
                "St-Sylvestre", "Quebec"
            },
            {
                "St-Theophile", "Quebec"
            },
            {
                "St-Thomas-d`Aquin", "Quebec"
            },
            {
                "St-Timothee", "Quebec"
            },
            {
                "St-Tite", "Quebec"
            },
            {
                "St-Tite-des-Caps", "Quebec"
            },
            {
                "St-Ubalde", "Quebec"
            },
            {
                "St-Ulric", "Quebec"
            },
            {
                "St-Urbain", "Quebec"
            },
            {
                "St-Victor", "Quebec"
            },
            {
                "St-Wenceslas", "Quebec"
            },
            {
                "St-Zacharie", "Quebec"
            },
            {
                "St-Zenon", "Quebec"
            },
            {
                "St-Zephirin", "Quebec"
            },
            {
                "St-Zotique", "Quebec"
            },
            {
                "St. Alban`s", "Newfoundland"
            },
            {
                "St. Albert", "Alberta"
            },
            {
                "St. Ambroise de Chicoutimi", "Quebec"
            },
            {
                "St. Anthony", "Newfoundland"
            },
            {
                "St. Basile de Portneuf", "Quebec"
            },
            {
                "St. Benedict", "Saskatchewan"
            },
            {
                "St. Bernard de Dorchester", "Quebec"
            },
            {
                "St. Bernard`s-Jacques Fontaine", "Newfoundland"
            },
            {
                "St. Brendan`s", "Newfoundland"
            },
            {
                "St. Bride`s", "Newfoundland"
            },
            {
                "St. Brieux", "Saskatchewan"
            },
            {
                "St. Catharines", "Ontario"
            },
            {
                "St. Charles", "Ontario"
            },
            {
                "St. Claude", "Manitoba"
            },
            {
                "St. Clements", "Ontario"
            },
            {
                "St. Come de Kennebec", "Quebec"
            },
            {
                "St. Davids", "Ontario"
            },
            {
                "St. Edouard de Frampton", "Quebec"
            },
            {
                "St. Fabien de Rimouski", "Quebec"
            },
            {
                "St. Ferdinand d`Halifax", "Quebec"
            },
            {
                "St. Fidele", "Quebec"
            },
            {
                "St. Francois Xavier", "Manitoba"
            },
            {
                "St. Gabriel de Rimouski", "Quebec"
            },
            {
                "St. Gedeon de Beauce", "Quebec"
            },
            {
                "St. George", "New Brunswick"
            },
            {
                "St. George", "Ontario"
            },
            {
                "St. George`s", "Newfoundland"
            },
            {
                "St. Gregoire de Nicolet", "Quebec"
            },
            {
                "St. Gregor", "Saskatchewan"
            },
            {
                "St. Henri de Levis", "Quebec"
            },
            {
                "St. Honore", "Quebec"
            },
            {
                "St. Isidore de Prescott", "Ontario"
            },
            {
                "St. Jacobs", "Ontario"
            },
            {
                "St. Jacques-Coomb`s Cove", "Newfoundland"
            },
            {
                "St. Jean Baptiste", "Manitoba"
            },
            {
                "St. John`s", "Newfoundland"
            },
            {
                "St. Laurent", "Manitoba"
            },
            {
                "St. Lawrence", "Newfoundland"
            },
            {
                "St. Lazare", "Manitoba"
            },
            {
                "St. Leon De Chic.", "Quebec"
            },
            {
                "St. Leonard", "New Brunswick"
            },
            {
                "St. Lewis", "Newfoundland"
            },
            {
                "St. Louis", "Saskatchewan"
            },
            {
                "St. Lunaire-Griquet", "Newfoundland"
            },
            {
                "St. Margaret Village", "Nova Scotia"
            },
            {
                "St. Martin de Beauce", "Quebec"
            },
            {
                "St. Martins", "New Brunswick"
            },
            {
                "St. Marys", "Ontario"
            },
            {
                "St. Mary`s", "Newfoundland"
            },
            {
                "St. Michael", "Alberta"
            },
            {
                "St. Moise", "Quebec"
            },
            {
                "St. Paul", "Alberta"
            },
            {
                "St. Peters", "Prince Edward Island"
            },
            {
                "St. Peter`s", "Nova Scotia"
            },
            {
                "St. Raphael de Bellechasse", "Quebec"
            },
            {
                "St. Regis", "Ontario"
            },
            {
                "St. Sebastien", "Quebec"
            },
            {
                "St. Stanislas de Champlain", "Quebec"
            },
            {
                "St. Stephen", "New Brunswick"
            },
            {
                "St. Theodore de Chertsey", "Quebec"
            },
            {
                "St. Thomas", "Ontario"
            },
            {
                "St. Victor de Beauce", "Quebec"
            },
            {
                "St. Vincent de Paul", "Quebec"
            },
            {
                "St. Vincent`s-St. Stephen`s-Pe", "Newfoundland"
            },
            {
                "St. Walburg", "Saskatchewan"
            },
            {
                "Stand Off", "Alberta"
            },
            {
                "Standard", "Alberta"
            },
            {
                "Stanley", "New Brunswick"
            },
            {
                "Stanley Mission", "Saskatchewan"
            },
            {
                "Stanstead", "Quebec"
            },
            {
                "Star City", "Saskatchewan"
            },
            {
                "Starbuck", "Manitoba"
            },
            {
                "Stavely", "Alberta"
            },
            {
                "Stayner", "Ontario"
            },
            {
                "Ste-Adele", "Quebec"
            },
            {
                "Ste-Agathe", "Quebec"
            },
            {
                "Ste-Agathe-des-Monts", "Quebec"
            },
            {
                "Ste-Agathe-Sud", "Quebec"
            },
            {
                "Ste-Anne-de-Beaupre", "Quebec"
            },
            {
                "Ste-Anne-de-Bellevue", "Quebec"
            },
            {
                "Ste-Anne-de-la-Perade", "Quebec"
            },
            {
                "Ste-Anne-de-Madawaska", "New Brunswick"
            },
            {
                "Ste-Anne-de-Portneuf", "Quebec"
            },
            {
                "Ste-Anne-des-Monts", "Quebec"
            },
            {
                "Ste-Anne-des-Plaines", "Quebec"
            },
            {
                "Ste-Anne-du-Lac", "Quebec"
            },
            {
                "Ste-Blandine", "Quebec"
            },
            {
                "Ste-Brigitte-de-Laval", "Quebec"
            },
            {
                "Ste-Catherine", "Quebec"
            },
            {
                "Ste-Clotilde-de-Horton", "Quebec"
            },
            {
                "Ste-Eulalie", "Quebec"
            },
            {
                "Ste-Felicite", "Quebec"
            },
            {
                "Ste-Foy", "Quebec"
            },
            {
                "Ste-Genevieve", "Quebec"
            },
            {
                "Ste-Helene-de-Bagot", "Quebec"
            },
            {
                "Ste-Henedine", "Quebec"
            },
            {
                "Ste-Jeanne-d`Arc", "Quebec"
            },
            {
                "Ste-Julie", "Quebec"
            },
            {
                "Ste-Julie-de-Vercheres", "Quebec"
            },
            {
                "Ste-Julienne", "Quebec"
            },
            {
                "Ste-Justine", "Quebec"
            },
            {
                "Ste-Lucie-de-Beauregard", "Quebec"
            },
            {
                "Ste-Madeleine", "Quebec"
            },
            {
                "Ste-Marguerite", "Quebec"
            },
            {
                "Ste-Marie-de-Beauce", "Quebec"
            },
            {
                "Ste-Marie-de-Blandford", "Quebec"
            },
            {
                "Ste-Marthe", "Quebec"
            },
            {
                "Ste-Marthe-sur-le-Lac", "Quebec"
            },
            {
                "Ste-Perpetue", "Quebec"
            },
            {
                "Ste-Petronille", "Quebec"
            },
            {
                "Ste-Rosalie", "Quebec"
            },
            {
                "Ste-Rose", "Quebec"
            },
            {
                "Ste-Rose-de-Watford", "Quebec"
            },
            {
                "Ste-Rose-du-Nord", "Quebec"
            },
            {
                "Ste-Sophie-de-Levrard", "Quebec"
            },
            {
                "Ste-Thecle", "Quebec"
            },
            {
                "Ste-Therese", "Quebec"
            },
            {
                "Ste-Veronique", "Quebec"
            },
            {
                "Ste-Victoire", "Quebec"
            },
            {
                "Ste. Agathe", "Manitoba"
            },
            {
                "Ste. Agathe de Lotbiniere", "Quebec"
            },
            {
                "Ste. Angele de Laval", "Quebec"
            },
            {
                "Ste. Cecile Masham", "Quebec"
            },
            {
                "Ste. Claire de Dorchester", "Quebec"
            },
            {
                "Ste. Croix de Lotbiniere", "Quebec"
            },
            {
                "Ste. Gertrude", "Quebec"
            },
            {
                "Ste. Justine de Newton", "Quebec"
            },
            {
                "Ste. Martine", "Quebec"
            },
            {
                "Ste. Methode de Frontenac", "Quebec"
            },
            {
                "Ste. Monique de Nicolet", "Quebec"
            },
            {
                "Ste. Rose du Lac", "Manitoba"
            },
            {
                "Steady Brook", "Newfoundland"
            },
            {
                "Steep Rock", "Manitoba"
            },
            {
                "Steinbach", "Manitoba"
            },
            {
                "Stellarton", "Nova Scotia"
            },
            {
                "Stephenville", "Newfoundland"
            },
            {
                "Stephenville Crossing", "Newfoundland"
            },
            {
                "Stettler", "Alberta"
            },
            {
                "Stevensville", "Ontario"
            },
            {
                "Stewart", "British Columbia"
            },
            {
                "Stewarttown", "Ontario"
            },
            {
                "Stewiacke", "Nova Scotia"
            },
            {
                "Stirling", "Alberta"
            },
            {
                "Stirling", "Ontario"
            },
            {
                "Stockholm", "Saskatchewan"
            },
            {
                "Stoke", "Quebec"
            },
            {
                "Stoke`s Bay", "Ontario"
            },
            {
                "Stoneham", "Quebec"
            },
            {
                "Stonewall", "Manitoba"
            },
            {
                "Stoney Creek", "Ontario"
            },
            {
                "Stoney Point", "Ontario"
            },
            {
                "Stony Plain", "Alberta"
            },
            {
                "Stony Rapids", "Saskatchewan"
            },
            {
                "Storthoaks", "Saskatchewan"
            },
            {
                "Stouffville", "Ontario"
            },
            {
                "Stoughton", "Saskatchewan"
            },
            {
                "Straffordville", "Ontario"
            },
            {
                "Strasbourg", "Saskatchewan"
            },
            {
                "Stratford", "Ontario"
            },
            {
                "Stratford", "Prince Edward Island"
            },
            {
                "Stratford", "Quebec"
            },
            {
                "Strathclair", "Manitoba"
            },
            {
                "Strathmore", "Alberta"
            },
            {
                "Strathroy", "Ontario"
            },
            {
                "Stratton", "Ontario"
            },
            {
                "Streetsville", "Ontario"
            },
            {
                "Strome", "Alberta"
            },
            {
                "Strongfield", "Saskatchewan"
            },
            {
                "Stroud", "Ontario"
            },
            {
                "Stukely-Sud", "Quebec"
            },
            {
                "Sturgeon Falls", "Ontario"
            },
            {
                "Sturgis", "Saskatchewan"
            },
            {
                "Sudbury", "Ontario"
            },
            {
                "Sultan", "Ontario"
            },
            {
                "Summer Beaver", "Ontario"
            },
            {
                "Summerford", "Newfoundland"
            },
            {
                "Summerland", "British Columbia"
            },
            {
                "Summerside", "Newfoundland"
            },
            {
                "Summerside", "Prince Edward Island"
            },
            {
                "Summerville", "New Brunswick"
            },
            {
                "Summit Lake", "British Columbia"
            },
            {
                "Sunderland", "Ontario"
            },
            {
                "Sundre", "Alberta"
            },
            {
                "Sundridge", "Ontario"
            },
            {
                "Sunnyside", "Newfoundland"
            },
            {
                "Surrey", "British Columbia"
            },
            {
                "Sussex", "New Brunswick"
            },
            {
                "Sutton", "Ontario"
            },
            {
                "Sutton", "Quebec"
            },
            {
                "Swan Hills", "Alberta"
            },
            {
                "Swan Lake", "Manitoba"
            },
            {
                "Swan River", "Manitoba"
            },
            {
                "Swastika", "Ontario"
            },
            {
                "Swift Current", "Saskatchewan"
            },
            {
                "Swift River", "Yukon"
            },
            {
                "Sydenham", "Ontario"
            },
            {
                "Sydney", "Nova Scotia"
            },
            {
                "Sylvan Lake", "Alberta"
            },
            {
                "Taber", "Alberta"
            },
            {
                "Tabusintac", "New Brunswick"
            },
            {
                "Tachie", "British Columbia"
            },
            {
                "Tadoule Lake", "Manitoba"
            },
            {
                "Tadoussac", "Quebec"
            },
            {
                "Tagish", "Yukon"
            },
            {
                "Tahsis", "British Columbia"
            },
            {
                "Tamworth", "Ontario"
            },
            {
                "Tangier", "Nova Scotia"
            },
            {
                "Tantallon", "Saskatchewan"
            },
            {
                "Tara", "Ontario"
            },
            {
                "Taschereau", "Quebec"
            },
            {
                "Tasiujaq", "Quebec"
            },
            {
                "Tatamagouche", "Nova Scotia"
            },
            {
                "Tatla Lake", "British Columbia"
            },
            {
                "Tavistock", "Ontario"
            },
            {
                "Taylor", "British Columbia"
            },
            {
                "Taylor Corners", "Ontario"
            },
            {
                "Tecumseh", "Ontario"
            },
            {
                "Teeswater", "Ontario"
            },
            {
                "Telegraph Creek", "British Columbia"
            },
            {
                "Telkwa", "British Columbia"
            },
            {
                "Temagami", "Ontario"
            },
            {
                "Temiscaming", "Quebec"
            },
            {
                "Terra Nova", "Newfoundland"
            },
            {
                "Terrace", "British Columbia"
            },
            {
                "Terrace Bay", "Ontario"
            },
            {
                "Terrasse Vaudreuil", "Quebec"
            },
            {
                "Terrebonne", "Quebec"
            },
            {
                "Terrenceville", "Newfoundland"
            },
            {
                "Teslin", "Yukon"
            },
            {
                "Tete-a-la-Baleine", "Quebec"
            },
            {
                "Teulon", "Manitoba"
            },
            {
                "Thamesford", "Ontario"
            },
            {
                "Thamesville", "Ontario"
            },
            {
                "The Eabametoong (Fort Hope) Fi", "Ontario"
            },
            {
                "The Pas", "Manitoba"
            },
            {
                "Thedford", "Ontario"
            },
            {
                "Theodore", "Saskatchewan"
            },
            {
                "Thessalon", "Ontario"
            },
            {
                "Thessalon First Nation", "Ontario"
            },
            {
                "Thetford Mines", "Quebec"
            },
            {
                "Thicket Portage", "Manitoba"
            },
            {
                "Thompson", "Manitoba"
            },
            {
                "Thorburn", "Nova Scotia"
            },
            {
                "Thorhild", "Alberta"
            },
            {
                "Thornbury", "Ontario"
            },
            {
                "Thorndale", "Ontario"
            },
            {
                "Thorne", "Ontario"
            },
            {
                "Thornhill", "Ontario"
            },
            {
                "Thorold", "Ontario"
            },
            {
                "Thorsby", "Alberta"
            },
            {
                "Three Hills", "Alberta"
            },
            {
                "Thrums", "British Columbia"
            },
            {
                "Thunder Bay", "Ontario"
            },
            {
                "Thurlow", "Ontario"
            },
            {
                "Thurso", "Quebec"
            },
            {
                "Tignish", "Prince Edward Island"
            },
            {
                "Tilbury", "Ontario"
            },
            {
                "Tilley", "Alberta"
            },
            {
                "Tillsonburg", "Ontario"
            },
            {
                "Timmins", "Ontario"
            },
            {
                "Tingwick", "Quebec"
            },
            {
                "Tisdale", "Saskatchewan"
            },
            {
                "Tiverton", "Ontario"
            },
            {
                "Toad River", "British Columbia"
            },
            {
                "Tobermory", "Ontario"
            },
            {
                "Tobique First Nation", "New Brunswick"
            },
            {
                "Tofield", "Alberta"
            },
            {
                "Tofino", "British Columbia"
            },
            {
                "Togo", "Saskatchewan"
            },
            {
                "Toledo", "Ontario"
            },
            {
                "Tomahawk", "Alberta"
            },
            {
                "Tompkins", "Saskatchewan"
            },
            {
                "Topley", "British Columbia"
            },
            {
                "Torbay", "Newfoundland"
            },
            {
                "Toronto", "Ontario"
            },
            {
                "Toronto Island", "Ontario"
            },
            {
                "Torquay", "Saskatchewan"
            },
            {
                "Torrington", "Alberta"
            },
            {
                "Tottenham", "Ontario"
            },
            {
                "Tracadie-Sheila", "New Brunswick"
            },
            {
                "Trail", "British Columbia"
            },
            {
                "Tramping Lake", "Saskatchewan"
            },
            {
                "Treherne", "Manitoba"
            },
            {
                "Tremblay", "Quebec"
            },
            {
                "Trenton", "Nova Scotia"
            },
            {
                "Trenton", "Ontario"
            },
            {
                "Trepassey", "Newfoundland"
            },
            {
                "Tribune", "Saskatchewan"
            },
            {
                "Tring-Jonction", "Quebec"
            },
            {
                "Triton", "Newfoundland"
            },
            {
                "Trochu", "Alberta"
            },
            {
                "Trois-Pistoles", "Quebec"
            },
            {
                "Trois-Rivieres", "Quebec"
            },
            {
                "Trout Creek", "Ontario"
            },
            {
                "Trout Lake", "Alberta"
            },
            {
                "Trout Lake", "British Columbia"
            },
            {
                "Trout Lake", "Northwest Territories"
            },
            {
                "Trout River", "Newfoundland"
            },
            {
                "Trowbridge", "Ontario"
            },
            {
                "Truro", "Nova Scotia"
            },
            {
                "Tsay Keh Dene", "British Columbia"
            },
            {
                "Tsiigehtchic", "Northwest Territories"
            },
            {
                "Tuktoyaktuk", "Northwest Territories"
            },
            {
                "Tumbler Ridge", "British Columbia"
            },
            {
                "Turner Valley", "Alberta"
            },
            {
                "Turnor Lake", "Saskatchewan"
            },
            {
                "Turtleford", "Saskatchewan"
            },
            {
                "Tusket", "Nova Scotia"
            },
            {
                "Tweed", "Ontario"
            },
            {
                "Twillingate", "Newfoundland"
            },
            {
                "Two Hills", "Alberta"
            },
            {
                "Tyne Valley", "Prince Edward Island"
            },
            {
                "Ucluelet", "British Columbia"
            },
            {
                "Udora", "Ontario"
            },
            {
                "Umiujaq", "Quebec"
            },
            {
                "Uniondale", "Ontario"
            },
            {
                "Unionville", "Ontario"
            },
            {
                "Unity", "Saskatchewan"
            },
            {
                "Upper Island Cove", "Newfoundland"
            },
            {
                "Upper Musquodoboit", "Nova Scotia"
            },
            {
                "Upper Stewiacke", "Nova Scotia"
            },
            {
                "Upsala", "Ontario"
            },
            {
                "Upton", "Quebec"
            },
            {
                "Uranium City", "Saskatchewan"
            },
            {
                "Utterson", "Ontario"
            },
            {
                "Uxbridge", "Ontario"
            },
            {
                "Val Marie", "Saskatchewan"
            },
            {
                "Val-Alain", "Quebec"
            },
            {
                "Val-Barrette", "Quebec"
            },
            {
                "Val-Belair", "Quebec"
            },
            {
                "Val-Brillant", "Quebec"
            },
            {
                "Val-David", "Quebec"
            },
            {
                "Val-des-Bois", "Quebec"
            },
            {
                "Val-d`Or", "Quebec"
            },
            {
                "Valcartier", "Quebec"
            },
            {
                "Valcourt", "Quebec"
            },
            {
                "Valemount", "British Columbia"
            },
            {
                "Vallee-Jonction", "Quebec"
            },
            {
                "Valley East", "Ontario"
            },
            {
                "Valleyview", "Alberta"
            },
            {
                "Vallican", "British Columbia"
            },
            {
                "Van Anda", "British Columbia"
            },
            {
                "Vancouver", "British Columbia"
            },
            {
                "Vanderhoof", "British Columbia"
            },
            {
                "Vanguard", "Saskatchewan"
            },
            {
                "Vanier", "Ontario"
            },
            {
                "Vanier", "Quebec"
            },
            {
                "Vankleek Hill", "Ontario"
            },
            {
                "Vanscoy", "Saskatchewan"
            },
            {
                "Varennes", "Quebec"
            },
            {
                "Vaudreuil", "Quebec"
            },
            {
                "Vaudreuil Dorion", "Quebec"
            },
            {
                "Vaudreuil-sur-le-Lac", "Quebec"
            },
            {
                "Vaughan", "Ontario"
            },
            {
                "Vauxhall", "Alberta"
            },
            {
                "Vavenby", "British Columbia"
            },
            {
                "Vegreville", "Alberta"
            },
            {
                "Venise-en-Quebec", "Quebec"
            },
            {
                "Vercheres", "Quebec"
            },
            {
                "Verdun", "Quebec"
            },
            {
                "Vermilion", "Alberta"
            },
            {
                "Vermilion Bay", "Ontario"
            },
            {
                "Verner", "Ontario"
            },
            {
                "Vernon", "British Columbia"
            },
            {
                "Vernon River", "Prince Edward Island"
            },
            {
                "Verona", "Ontario"
            },
            {
                "Veteran", "Alberta"
            },
            {
                "Vibank", "Saskatchewan"
            },
            {
                "Victoria", "British Columbia"
            },
            {
                "Victoria", "Newfoundland"
            },
            {
                "Victoria", "Ontario"
            },
            {
                "Victoriaville", "Quebec"
            },
            {
                "View Royal", "British Columbia"
            },
            {
                "Viking", "Alberta"
            },
            {
                "Ville-Marie", "Quebec"
            },
            {
                "Vilna", "Alberta"
            },
            {
                "Vimont", "Quebec"
            },
            {
                "Vineland", "Ontario"
            },
            {
                "Virden", "Manitoba"
            },
            {
                "Virginiatown", "Ontario"
            },
            {
                "Viscount", "Saskatchewan"
            },
            {
                "Vita", "Manitoba"
            },
            {
                "Vonda", "Saskatchewan"
            },
            {
                "Vulcan", "Alberta"
            },
            {
                "Waasagomach", "Manitoba"
            },
            {
                "Wabamun", "Alberta"
            },
            {
                "Wabana", "Newfoundland"
            },
            {
                "Wabigoon", "Ontario"
            },
            {
                "Wabowden", "Manitoba"
            },
            {
                "Wabush", "Newfoundland"
            },
            {
                "Wadena", "Saskatchewan"
            },
            {
                "Wainfleet", "Ontario"
            },
            {
                "Wainwright", "Alberta"
            },
            {
                "Wakaw", "Saskatchewan"
            },
            {
                "Wakefield", "Quebec"
            },
            {
                "Walden", "Ontario"
            },
            {
                "Waldheim", "Saskatchewan"
            },
            {
                "Walkerton", "Ontario"
            },
            {
                "Wallace", "Nova Scotia"
            },
            {
                "Wallaceburg", "Ontario"
            },
            {
                "Walsh", "Alberta"
            },
            {
                "Walton", "Nova Scotia"
            },
            {
                "Wandering River", "Alberta"
            },
            {
                "Wanham", "Alberta"
            },
            {
                "Wanless", "Manitoba"
            },
            {
                "Wapekeka First Nation", "Ontario"
            },
            {
                "Wapella", "Saskatchewan"
            },
            {
                "Warburg", "Alberta"
            },
            {
                "Warden", "Quebec"
            },
            {
                "Wardsville", "Ontario"
            },
            {
                "Warkworth", "Ontario"
            },
            {
                "Warman", "Saskatchewan"
            },
            {
                "Warner", "Alberta"
            },
            {
                "Warren", "Ontario"
            },
            {
                "Warspite", "Alberta"
            },
            {
                "Warwick", "Quebec"
            },
            {
                "Wasaga Beach", "Ontario"
            },
            {
                "Wasagaming", "Manitoba"
            },
            {
                "Waskaganish", "Quebec"
            },
            {
                "Waskatenau", "Alberta"
            },
            {
                "Waskesiu Lake", "Saskatchewan"
            },
            {
                "Waswanipi", "Quebec"
            },
            {
                "Waterdown", "Ontario"
            },
            {
                "Waterford", "Ontario"
            },
            {
                "Waterhen", "Manitoba"
            },
            {
                "Waterloo", "Ontario"
            },
            {
                "Waterloo", "Quebec"
            },
            {
                "Waterville", "Quebec"
            },
            {
                "Watford", "Ontario"
            },
            {
                "Watrous", "Saskatchewan"
            },
            {
                "Watson", "Saskatchewan"
            },
            {
                "Watson Lake", "Yukon"
            },
            {
                "Waubaushene", "Ontario"
            },
            {
                "Waverley", "Nova Scotia"
            },
            {
                "Wawa", "Ontario"
            },
            {
                "Wawanesa", "Manitoba"
            },
            {
                "Wawota", "Saskatchewan"
            },
            {
                "Webb", "Saskatchewan"
            },
            {
                "Webbwood", "Ontario"
            },
            {
                "Webequie", "Ontario"
            },
            {
                "Wedgeport", "Nova Scotia"
            },
            {
                "Weedon", "Quebec"
            },
            {
                "Weedon Centre", "Quebec"
            },
            {
                "Welcome", "Ontario"
            },
            {
                "Welland", "Ontario"
            },
            {
                "Wellandport", "Ontario"
            },
            {
                "Wellesley", "Ontario"
            },
            {
                "Wellington", "Ontario"
            },
            {
                "Wellington", "Prince Edward Island"
            },
            {
                "Wells", "British Columbia"
            },
            {
                "Welsford", "New Brunswick"
            },
            {
                "Welwyn", "Saskatchewan"
            },
            {
                "Wembley", "Alberta"
            },
            {
                "Wemindji", "Quebec"
            },
            {
                "Wendover", "Quebec"
            },
            {
                "Wesleyville", "Newfoundland"
            },
            {
                "West Brome", "Quebec"
            },
            {
                "West Guilford", "Ontario"
            },
            {
                "West Lincoln", "Ontario"
            },
            {
                "West Lorne", "Ontario"
            },
            {
                "West Vancouver", "British Columbia"
            },
            {
                "Westbank", "British Columbia"
            },
            {
                "Westbury", "Quebec"
            },
            {
                "Western Bay", "Newfoundland"
            },
            {
                "Westfield", "New Brunswick"
            },
            {
                "Westlock", "Alberta"
            },
            {
                "Westmeath", "Ontario"
            },
            {
                "Westmount", "Quebec"
            },
            {
                "Westport", "Newfoundland"
            },
            {
                "Westport", "Ontario"
            },
            {
                "Westree", "Ontario"
            },
            {
                "Westville", "Nova Scotia"
            },
            {
                "Westwold", "British Columbia"
            },
            {
                "Wetaskiwin", "Alberta"
            },
            {
                "Weyburn", "Saskatchewan"
            },
            {
                "Weymouth", "Nova Scotia"
            },
            {
                "Whale Cove", "Nunavut"
            },
            {
                "Wheatley", "Ontario"
            },
            {
                "Whistler", "British Columbia"
            },
            {
                "Whitbourne", "Newfoundland"
            },
            {
                "Whitby", "Ontario"
            },
            {
                "Whitchurch-Stouffville", "Ontario"
            },
            {
                "White Fox", "Saskatchewan"
            },
            {
                "White River", "Ontario"
            },
            {
                "White Rock", "British Columbia"
            },
            {
                "Whitecourt", "Alberta"
            },
            {
                "Whitefish", "Ontario"
            },
            {
                "Whitefish Falls", "Ontario"
            },
            {
                "Whitefish River First Nation", "Ontario"
            },
            {
                "Whitehorse", "Yukon"
            },
            {
                "Whitelaw", "Alberta"
            },
            {
                "Whitemouth", "Manitoba"
            },
            {
                "Whitewood", "Saskatchewan"
            },
            {
                "Whitney", "Ontario"
            },
            {
                "Whycocomagh", "Nova Scotia"
            },
            {
                "Wiarton", "Ontario"
            },
            {
                "Wickham", "Quebec"
            },
            {
                "Widewater", "Alberta"
            },
            {
                "Wikwemikong", "Ontario"
            },
            {
                "Wilberforce", "Ontario"
            },
            {
                "Wilcox", "Saskatchewan"
            },
            {
                "Wildwood", "Alberta"
            },
            {
                "Wilkie", "Saskatchewan"
            },
            {
                "Williams Lake", "British Columbia"
            },
            {
                "Williamsburg", "Ontario"
            },
            {
                "Willingdon", "Alberta"
            },
            {
                "Willow Bunch", "Saskatchewan"
            },
            {
                "Willowbrook", "British Columbia"
            },
            {
                "Winchester", "Ontario"
            },
            {
                "Windermere", "Ontario"
            },
            {
                "Windsor", "Nova Scotia"
            },
            {
                "Windsor", "Ontario"
            },
            {
                "Windsor", "Quebec"
            },
            {
                "Windthorst", "Saskatchewan"
            },
            {
                "Winfield", "Alberta"
            },
            {
                "Winfield", "British Columbia"
            },
            {
                "Wingham", "Ontario"
            },
            {
                "Winkler", "Manitoba"
            },
            {
                "Winnipeg", "Manitoba"
            },
            {
                "Winnipeg Beach", "Manitoba"
            },
            {
                "Winnipegosis", "Manitoba"
            },
            {
                "Winona", "Ontario"
            },
            {
                "Winter Harbour", "British Columbia"
            },
            {
                "Winterton", "Newfoundland"
            },
            {
                "Wiseton", "Saskatchewan"
            },
            {
                "Wishart", "Saskatchewan"
            },
            {
                "Witless Bay", "Newfoundland"
            },
            {
                "Woburn", "Quebec"
            },
            {
                "Woking", "Alberta"
            },
            {
                "Wolfville", "Nova Scotia"
            },
            {
                "Wollaston Lake", "Saskatchewan"
            },
            {
                "Wolseley", "Saskatchewan"
            },
            {
                "Wonowon", "British Columbia"
            },
            {
                "Wood Mountain", "Saskatchewan"
            },
            {
                "Woodbridge", "Ontario"
            },
            {
                "Woodridge", "Manitoba"
            },
            {
                "Woodstock", "New Brunswick"
            },
            {
                "Woodstock", "Ontario"
            },
            {
                "Woodville", "Ontario"
            },
            {
                "Woody Point", "Newfoundland"
            },
            {
                "Wooler", "Ontario"
            },
            {
                "Worsley", "Alberta"
            },
            {
                "Wotton", "Quebec"
            },
            {
                "Wrentham", "Alberta"
            },
            {
                "Wrigley", "Northwest Territories"
            },
            {
                "Wunnummin Lake", "Ontario"
            },
            {
                "Wynndel", "British Columbia"
            },
            {
                "Wynyard", "Saskatchewan"
            },
            {
                "Wyoming", "Ontario"
            },
            {
                "Yahk", "British Columbia"
            },
            {
                "Yale", "British Columbia"
            },
            {
                "Yamachiche", "Quebec"
            },
            {
                "Yamaska", "Quebec"
            },
            {
                "Yamaska-Est", "Quebec"
            },
            {
                "Yarker", "Ontario"
            },
            {
                "Yarmouth", "Nova Scotia"
            },
            {
                "Yellow Creek", "Saskatchewan"
            },
            {
                "Yellow Grass", "Saskatchewan"
            },
            {
                "Yellowknife", "Northwest Territories"
            },
            {
                "York", "Ontario"
            },
            {
                "Yorkton", "Saskatchewan"
            },
            {
                "Youbou", "British Columbia"
            },
            {
                "Young", "Saskatchewan"
            },
            {
                "Youngstown", "Alberta"
            },
            {
                "Young`s Cove Road", "New Brunswick"
            },
            {
                "Zealandia", "Saskatchewan"
            },
            {
                "Zeballos", "British Columbia"
            },
            {
                "Zenon Park", "Saskatchewan"
            },
            {
                "Zurich", "Ontario"
            }
        };
    }
}