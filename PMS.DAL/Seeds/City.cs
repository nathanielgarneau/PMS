using System;
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


        private readonly List<KeyValuePair<string, string>> CanadianCities = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string,string>(
                "100 Mile House", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "108 Mile House", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "108 Mile Ranch", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "150 Mile House", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Abbey", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Abbotsford", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Aberarder", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Abercorn", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Aberdeen", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Abernethy", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Abitibi Canyon", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Acadia Valley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Acme", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Acton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Acton Vale", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Adamsville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Adolphustown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Advocate Harbour", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Agassiz", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Agassiz Provincial Forest", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Aguanish", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ahousat", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Ailsa Craig", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Airdrie", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Ajax", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Aklavik", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Alameda", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Alban", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Albanel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Albert", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Albert Mines", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Alberta Beach", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Alberton", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Alder Flats", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Aldergrove", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Alderville First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Alert Bay", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Alexander", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Alexandria", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Alexis Creek", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Alfred", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Algoma Mills", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Alida", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Alix", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Alkali Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Allan", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Allardville", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Alliance", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Alliston", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Alma", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Alma", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Almonte", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Alonsa", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Alouette", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Alsask", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Altario", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Altona", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Alvena", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Alvinston", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Amherst", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Amherstburg", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Amos", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Amqui", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ancaster", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Andrew", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Aneroid", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Angliers", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Angus", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Anjou", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Annapolis Royal", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Anse-Saint-Jean", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Antigonish", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Anzac", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Appleton", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Apsley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Arborfield", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Arborg", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Archerwill", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Arcola", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Arden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ardrossan", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Argentia", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Argyle", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Arichat", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Arkell", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Arkona", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Armagh", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Armstrong", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Armstrong", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Arnold`s Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Arnprior", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Arrowwood", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Arthur", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Arundel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Arviat", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Asbestos", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ascot", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ascot Corner", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ashcroft", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Ashern", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Ashmont", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Ashuapmushuan", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Asquith", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Assiniboia", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Assumption", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Aston-Jonction", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Athabasca", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Athens", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Atikokan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Atlin", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Attawapiskat", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Atwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Auburn", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Aurora", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Austin", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Avola", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Avondale", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Avonlea", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Avonmore", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ayer`s Cliff", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Aylesford", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Aylmer", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Aylmer", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ayr", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ayton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Azilda", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Baddeck", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Baden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Badger", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Bagotville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Baie Verte", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Baie-Comeau", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Baie-de-Shawinigan", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Baie-des-Sables", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Baie-du-Febvre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Baie-d`Urfe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Baie-Johan-Beetz", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Baie-Sainte-Catherine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Baie-St-Paul", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Baie-Ste-Anne", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Baie-Trinite", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bailieboro", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Baker Brook", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Baker Lake", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Bala", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Balcarres", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Baldur", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Balfour", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Balgonie", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Balmertown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Balmoral", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Baltimore", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bamfield", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Bancroft", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Banff", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Barachois", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Barkmere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Barons", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Barraute", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Barrhead", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Barrie", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Barriere", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Barry`s Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Barwick", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bashaw", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bass River", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Bassano", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Basswood", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Batawa", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Batchawana Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bath", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Bath", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bathurst", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Batiscan", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Batteau", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Battle Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Battleford", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Bauline", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Bawlf", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bay Bulls", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Bay de Verde", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Bay L`Argent", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Bay Roberts", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Bayfield", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Baysville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Beach Grove", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Beachburg", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Beachville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Beaconsfield", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Beamsville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bear Canyon", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bear Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Bear River", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Beardmore", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bearskin Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bearskin Lake First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bear`s Passage", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Beaucanton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Beauceville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Beauharnois", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Beaulac-Garthby", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Beaumont", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Beaumont", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Beaumont", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Beauport", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Beaupre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Beausejour", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Beauval", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Beaver Cove", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Beaver Creek", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Beaverdell", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Beaverlodge", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Beaverton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Becancour", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bedeque", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Bedford", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Beechy", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Beeton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Beiseker", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bell Island", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Bella Bella", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Bella Coola", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Belle Neige", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Belle River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Belledune", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Bellefeuille", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Belleoram", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Belleterre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Belleville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bellevue", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Belmont", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Belmont", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Beloeil", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bengough", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Benito", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Benoit`s Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Bentley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Berens River", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Beresford", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Bergeronnes", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Berthierville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Berwick", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Berwyn", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bethany", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bethesda", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bethune", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Betsiamites", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Beulah", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Biencourt", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bienfait", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Big River", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Big Trout Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Big Valley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Biggar", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Binbrook", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bindloss", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Binscarth", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Birch Hills", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Birch Island", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Birchy Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Birsay", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Birtle", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Biscotasing", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bishopton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bishop`s Falls", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Bissett", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Black Creek", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Black Diamond", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Black Duck Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Black Lake", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Black Point", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Black Tickle", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Blackfalds", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Blackie", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Blacks Harbour", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Blackstock", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Blackville", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Blaine Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Blainville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Blanc-Sablon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Blandford", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Blenheim", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Blezard Valley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Blind River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bloomfield", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Blue Ridge", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Blue River", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Blyth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bob Quinn Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Bobcaygeon", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Boiestown", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Bois-des-Filion", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Boisbriand", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Boischatel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Boisdale", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Boissevain", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Bolton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bon Accord", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bonanza", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bonaventure", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bonavista", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Bonfield", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bonne-Esperance", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bonnyville", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Borden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Borden", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Borden", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Boston Bar", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Boswell", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Bothwell", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Botwood", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Boucherville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bouchette", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bouctouche", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Boularderie", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Bourget", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bow Island", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bowden", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bowen Island", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Bowmanville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bowser", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Boyd`s Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Boyle", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bracebridge", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bradford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bradford West Gwillimbury", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Braeside", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bragg Creek", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Brampton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Branch", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Brandon", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Brantford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Breakeyville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Brechin", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bredenbury", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Brent`s Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Breslau", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Breton", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bridge Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Bridgenorth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bridgetown", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Bridgewater", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Briercrest", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Brigden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Brigham", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bright", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Brighton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Brights Grove", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Brigus", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Britannia Beach", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Britt", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Broadview", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Brochet", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Brock", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Brocket", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Brockville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Brome", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bromont", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Bromptonville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Brookdale", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Brookfield", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Brooklin", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Brooks", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Brossard", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Browns Flat", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Brownsburg", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Brownsville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Brownvale", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bruce Mines", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bruderheim", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Bruno", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Brussels", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Bryson", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Buchanan", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Buchans", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Buckhorn", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Buckingham", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Buffalo Narrows", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Burdett", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Burford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Burgeo", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Burgessville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Burin", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Burk`s Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Burleigh Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Burlington", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Burlington", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Burnaby", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Burns Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Burnt Islands", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Burstall", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Burwash Landing", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Bury", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Byemoor", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Cabano", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cabri", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Cache Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cache Creek", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Cacouna", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cadillac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cadillac", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Cadomin", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Calabogie", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Calder", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Caledon", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Caledon East", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Caledonia", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Calgary", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Callander", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Calling Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Calmar", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Calstock", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Calumet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cambray", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cambridge", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cambridge Bay", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Cameron", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Camlachie", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Campbell River", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Campbellford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Campbellton", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Campbellton", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Campbellville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Campbell`s Bay", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Camperville", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Campobello Island", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Camrose", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Canal Flats", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Candiac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Canmore", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Canning", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Cannington", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Canoe Narrows", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Canora", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Canso", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Canterbury", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Cantley", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Canwood", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Cap-a-l`Aigle", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cap-aux-Meules", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cap-Chat", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cap-de-la-Madeleine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cap-des-Rosiers", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cap-Pele", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Cap-Rouge", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cap-Saint-Ignace", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cape Broyle", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Cape Dorset", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Caplan", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Capreol", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Caradoc First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Caramat", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Caraquet", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Carberry", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Carbon", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Carbonear", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Carcross", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Cardiff", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cardigan", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Cardinal", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cardston", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Cargill", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Caribou", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Carievale", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Carignan", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Carillon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Carleton", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Carleton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Carleton Place", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Carlyle", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Carmacks", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Carman", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Carmangay", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Carmanville", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Carnarvon", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Carnduff", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Caroline", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Caron", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Carp", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Carrot River", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Carseland", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Carstairs", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Cartier", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cartwright", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Cartwright", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Casselman", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cassiar", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Castlegar", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Castlemore", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Castleton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Castor", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Cat Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Catalina", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Causapscal", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cavan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cayley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Cayuga", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Celista", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Central Butte", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Centralia", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Centreville", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Centreville-Wareham-Trinity", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Cereal", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Cessford", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Ceylon", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Chalk River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Chambly", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chambord", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Champion", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Champlain", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chance Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Chandler", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Change islands", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Chapais", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chapeau", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chapel Arm", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Chapleau", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Chaplin", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Charette", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Charlemagne", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Charlesbourg", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Charlevoix", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Charlottetown", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Charlottetown", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Charlton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Charny", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chartierville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chase", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Chateau-Richer", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chateauguay", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chatham", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Chatham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Chatsworth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Chauvin", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Chelmsford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Chelsea", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Chelsea", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chemainus", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Cheneville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chesley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Chester", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Chesterfield Inlet", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Chestermere", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Chesterville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Chesterville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cheticamp", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Chetwynd", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Cheverie", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Chevery", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chibougamau", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chicoutimi", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chiefs Point First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Chilliwack", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Chipewyan Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Chipman", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Chipman", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Chippewas of Kettle/Stony Poin", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Chippewas Of Sarnia First Nati", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Chisasibi", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Choiceland", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Chomedey", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Christian Island", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Christina Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Christopher Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Churchbridge", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Churchill", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Churchill Falls", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Chute-aux-Outardes", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Chute-des-Passes", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Clair", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Clairmont", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Claremont", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Clarence Creek", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Clarence-Rockland", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Clarenville", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Clarenville-Shoal Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Claresholm", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Clarington", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Clarke`s Beach", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Clarks Corners", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Clarkson", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Clarksville", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Clark`s Harbour", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Clavet", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Clearwater", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Clearwater Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Clericy", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Clermont", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Clifford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Climax", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Clinton", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Clinton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Clive", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Cloridorme", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cloud Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Clova", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Clyde", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Coaldale", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Coalhurst", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Coaticook", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cobalt", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cobble Hill", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Cobden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Coboconk", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cobourg", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cocagne", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Cochenour", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cochin", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Cochrane", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Cochrane", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Coderre", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Codroy", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Coe Hill", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Colborne", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Colchester", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cold Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Cold Springs", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Coldwater", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Coleville", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Colliers", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Collingwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Collingwood Corner", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Colombier", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Colonsay", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Colwood", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Comber", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Come By Chance", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Comfort Cove-Newstead", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Comox", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Compton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Conception Bay South", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Conception Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Conche", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Concord", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Coniston", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Conklin", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Connaught", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Conne River", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Conquest", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Consort", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Constance Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Constance Lake First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Consul", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Contrecoeur", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cookshire", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cookstown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cooksville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cook`s Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Coquitlam", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Coral Harbour", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Cormorant", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Corner Brook", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Cornwall", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cornwall", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Coronach", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Coronation", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Corunna", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cote-St-Luc", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Coteau-du-Lac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cottam", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cottlesville", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Courcelette", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Courcelles", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Courtenay", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Courtice", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Courtright", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Coutts", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Covehead", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Cow Head", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Cowan", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Cowansville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Cowichan Bay", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Cowley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Crabtree", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Craigmyle", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Craik", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Cranberry Portage", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Cranbrook", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Crandall", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Crapaud", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Crawford Bay", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Crediton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Creelman", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Creemore", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Creighton", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Cremona", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Crescent Beach", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Creston", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Cross Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Crossfield", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Crowsnest Pass", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Crysler", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Crystal Beach", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Crystal City", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Cudworth", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Cumberland", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Cumberland", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Cumberland House", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Cupar", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Cupids", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Cut Knife", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Cypress River", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Czar", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Dalhousie", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Dalmeny", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Daniel`s Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Danville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Darlingford", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Dartmouth", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Dashwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dauphin", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Daveluyville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Davidson", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Davis Inlet", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Dawson", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Dawson Creek", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Daysland", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Dease Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Deauville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Debden", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Debec", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Debert", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "DeBolt", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Deep River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Deer Lake", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Deer Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Deerbrook", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Degelis", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Delaware of the Thames(Moravia", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Delburne", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Delhi", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Delia", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Delisle", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Delisle", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Deloraine", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Delson", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Delta", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Delta", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Denbigh", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Denzil", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Derwent", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Desbarats", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Desbiens", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Deschaillons-sur-Saint-Laurent", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Deseronto", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Destruction Bay", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Deux-Montagnes", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Deux-Rivieres", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Devlin", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Devon", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Dewberry", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Didsbury", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Dieppe", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Digby", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Dillon", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Dingwall", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Dinsmore", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Disraeli", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Dixonville", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Doaktown", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Dodsland", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Dokis", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dokis First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dolbeau-Mistassini", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Dollard-des-Ormeaux", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Dominion City", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Domremy", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Donald", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Donalda", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Donnacona", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Donnelly", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Dorchester", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Dorchester", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dorion", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dorset", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dorval", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Douglas", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Douglas Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Douglastown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dover", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Drake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Drayton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Drayton Valley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Dresden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Drumbo", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Drumheller", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Drummondville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Dryden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dublin", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dubreuilville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dubuc", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Dubuisson", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Duchess", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Duck Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Dugald", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Duncan", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Dunchurch", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dundalk", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dundas", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dundee", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Dundurn", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Dungannon", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dunham", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Dunnville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dunsford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dunster", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Duparquet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Dupuy", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Durham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dutton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Duvernay", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Dwight", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dyer`s Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Dysart", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "D`Arcy", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Eagle Lake First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Eagle River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Eaglesham", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Ear Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Earl Grey", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Earlton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "East Angus", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "East Bay", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "East Broughton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "East Coulee", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "East Farnham", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "East Gwillimbury", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "East Hereford", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "East Pine", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "East Point", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "East York", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Eastend", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Easterville", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Eastmain", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Eastman", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Eastport", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Eastwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Eatonia", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Echo Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Eckville", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Ecum Secum", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Edam", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Eddystone", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Edgerton", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Edmonton", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Edmundston", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Edson", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Edwin", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Edzo", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Eganville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Elbow", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Eldon", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Elfros", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Elgin", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Elgin", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Elie", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Elizabethtown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Elk Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Elk Point", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Elkford", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Elkhorn", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Elko", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Elkwater", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Elliot Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Elliston", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Elm Creek", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Elmira", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Elmsdale", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Elmvale", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Elnora", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Elora", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Elrose", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Embree", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Embro", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Embrun", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Emerson", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Emeryville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Emo", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Empress", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Emsdale", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Enchant", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Enderby", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Englee", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Englehart", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "English Harbour East", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Enterprise", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Enterprise", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Entrelacs", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Erickson", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Eriksdale", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Erin", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Eskasoni", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Espanola", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Essex", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Estaire", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Esterel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Esterhazy", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Estevan", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Estevan Point", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Eston", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Ethelbert", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Etobicoke", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Etzikom", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Eugenia", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Evain", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Evansburg", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Exeter", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Exshaw", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Eyebrow", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Fabre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Fabreville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Fair Haven", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Fairmont Hot Springs", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Fairview", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Falardeau", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Falcon Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Falher", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Falkland", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Farnham", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Faro", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Fassett", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Fauquier", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Fauquier", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Faust", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Fenelon Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fenwick", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fergus", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ferintosh", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Ferland", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ferme-Neuve", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Fermeuse", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Fermont", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Fernie", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Feversham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Field", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Field", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fillmore", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Finch", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fingal", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fisher Branch", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Fisher River", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Fisherville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Flamborough", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Flanders", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Flatbush", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Flatrock", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Flatrock", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Fleming", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Flesherton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fleur de Lys", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Fleurimont", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Flin Flon", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Florenceville", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Flower`s Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Foam Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Fogo", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Foley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Foleyet", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fond-du-Lac", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Fords Mills", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Foremost", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Forest", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Forest Grove", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Forestburg", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Forestville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Fork River", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Fort Albany", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fort Assiniboine", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Fort Chipewyan", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Fort Erie", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fort Frances", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fort Fraser", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Fort Good Hope", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Fort Hope", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fort Liard", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Fort MacKay", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Fort Macleod", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Fort McMurray", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Fort McPherson", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Fort Nelson", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Fort Providence", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Fort Qu`Appelle", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Fort Saskatchewan", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Fort Severn", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fort Severn First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fort Simpson", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Fort Smith", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Fort St. James", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Fort St. John", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Fort Vermilion", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Fort William First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Fort-Coulonge", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Forteau", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Fortierville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Fortune", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Fossambault-sur-le-Lac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Fox Cove-Mortier", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Fox Creek", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Fox Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Fox Valley", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Foxboro", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Foxwarren", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Foymount", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Frampton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Francis", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Frankford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Franklin Centre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Fraser Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Fredericton", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Fredericton Junction", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Freelton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Freeport", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Frelighsburg", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "French River First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "French Village", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Frenchmans Island", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Freshwater", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Frobisher", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Frontier", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Fruitvale", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Fugereville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Gabarus", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Gabriola", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Gadsby", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Gagetown", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Gainsborough", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Galahad", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Galiano Island", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Galt", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gambo", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Gananoque", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gander", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Ganges", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Garden Hill", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Garden River First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Garnish", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Garson", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gaspe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Gatineau", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Gaultois", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Gentilly", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Georgetown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Georgetown", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Georgina", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Geraldton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gibbons", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Gibsons", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Gift Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Gilbert Plains", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Gillam", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Gilmour", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gimli", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Girardville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Girouxville", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Giscome", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Gjoa Haven", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Glace Bay", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Gladstone", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Glaslyn", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Glassville", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Gleichen", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Glen Ewen", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Glen Robertson", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Glen Water", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Glen Williams", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Glenavon", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Glenboro", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Glencoe", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Glendon", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Glenella", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Glenwood", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Glenwood", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Gloucester", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Glovertown", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Godbout", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Goderich", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gods Lake Narrows", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Gogama", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gold Bridge", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Gold River", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Goldboro", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Golden", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Golden Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Good Hope Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Gooderham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Goodeve", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Goodsoil", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Goose Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Gore Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gormley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gorrie", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Goshen", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Goulais River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Govan", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Gowganda", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gracefield", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Grafton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Granby", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Grand Bank", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Grand Bay", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Grand Beach", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Grand Bend", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Grand Centre", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Grand Etang", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Grand Falls", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Grand Falls", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Grand Falls-Windsor", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Grand Forks", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Grand Lake", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Grand Manan", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Grand Narrows", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Grand Rapids", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Grand Valley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Grand-Mere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Grand-Remous", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Grand-Sault", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Grande Cache", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Grande Prairie", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Grande-Anse", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Grande-Entree", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Grande-Riviere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Grande-Vallee", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Grandes-Bergeronnes", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Grandes-Piles", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Grandview", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Granisle", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Granton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Granum", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Grasmere", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Grassland", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Grassy Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Grassy Narrows", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Grassy Narrows First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Grassy Plains", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Gravelbourg", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Gravenhurst", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Grayson", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Great Harbour Deep", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Great Village", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Green Island Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Green Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Greenfield Park", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Greenspond", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Greensville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Greenville", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Greenwood", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Greenwood", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Grenfell", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Grenville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Gretna", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Grimsby", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Grimshaw", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Grouard", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Guelph", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Guigues", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Gull Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gull Bay First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Gull Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Guysborough", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Gypsumville", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Hadashville", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Hafford", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Hagersville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hague", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Haileybury", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Haines Junction", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Hairy Hill", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Haldimand", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Haliburton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Halifax", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Halkirk", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Halton Hills", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ham-Nord", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Hamilton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hamiota", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Hammond", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Hampden", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Hampstead", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Hampstead", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Hampton", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Hampton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hanley", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Hanmer", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hanna", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hanover", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hantsport", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Hant`s Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Happy Valley-Goose Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Harbour Breton", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Harbour Grace", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Harbour Main-Chapel Cove-Lakev", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Hardisty", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hare Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Harewood", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Harrietsville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Harrington Harbour", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Harris", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Harriston", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Harrow", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Harrowsmith", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hartland", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Hartley Bay", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Hartney", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Hastings", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Havelock", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Havelock", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Havre-Aubert", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Havre-aux-Maisons", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Havre-St-Pierre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Hawarden", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Hawk Junction", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hawkesbury", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hawke`s Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Hay Lakes", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hay River", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Hays", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hazelton", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Hazlet", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Hearst", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Heart`s Content", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Heart`s Delight-Islington", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Heart`s Desire", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Heatherton", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Hebertville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Hebertville-Station", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Hecla", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Hedley", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Heinsburg", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Heisler", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hemlo", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hemlock Valley", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Hemmingford", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Hendrix Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Henryville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Hensall", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Henvey Inlet First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hepburn", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Hepworth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Herbert", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Herschel", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Hespeler", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hickman`s Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Hickson", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "High Level", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "High Prairie", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "High River", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Highgate", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hilda", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hillgrade", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Hillsborough", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Hillsburgh", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hillview", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Hines Creek", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hinton", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hixon", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Hobbema", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hodgeville", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Holberg", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Holden", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Holdfast", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Holland", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Holland Landing", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Holstein", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Holyrood", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Honey Harbour", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hope", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Hopedale", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Hopewell", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Hornepayne", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Horsefly", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Houston", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Howick", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Howley", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Hoyt", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Hubbards", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Hudson", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hudson", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Hudson Bay", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Hudson`s Hope", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Hughenden", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hull", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Humber Arm South", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Humboldt", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Humphrey", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hunter River", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Huntingdon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Huntsville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Hussar", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Hythe", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Iberville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ignace", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ilderton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ile-a-la-Crosse", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Ile-aux-Coudres", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Iles-de-la-Madeleine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ilford", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Imperial", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Indian Head", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Indian Tickle", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Ingersoll", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ingleside", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ingonish", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Innerkip", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Innisfail", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Innisfil", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Innisfree", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Inukjuak", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Inuvik", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Inverary", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Invermay", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Invermere", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Inverness", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Inverness", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Inwood", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Inwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Iqaluit", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Irma", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Iron Bridge", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Iron Springs", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Iroquois", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Iroquois Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Irricana", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Irvine", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Iskut", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Island Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Island Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Islay", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Isle aux Morts", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Ituna", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Jackson`s Arm", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Jacquet River", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Jaffray", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Jaffray Melick", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Jamestown", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Jansen", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Jarvie", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Jarvis", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Jasper", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Jasper", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Jean Marie River", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Jellicoe", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Jenner", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Jockvale", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Joe Batt`s Arm-Barr`d Islands-", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Johnstown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Joliette", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Jonquiere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Jordan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Joussard", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Joutel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Kakisa", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Kaministiquia", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kamiskotia", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kamloops", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kamsack", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kananaskis", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Kanata", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kangiqsualujjuaq", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Kangirsuk", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Kapuskasing", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kasabonika First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kashechewan First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kaslo", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kateville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Kazabazua", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Kearney", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kedgwick", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Keene", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Keephills", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Keewatin", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Keg River", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Kelliher", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kelowna", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kelvington", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kelwood", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Kemano", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kemptville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kenaston", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kennedy", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kennetcook", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Kenora", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kenosee", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kensington", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Kent Centre", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kenton", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Kentville", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Kenzieville", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Keremeos", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kerrobert", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kerwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Keswick", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Keswick", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ketch Harbour", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Key Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Killaloe", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Killam", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Killarney", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Killarney", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kimberley", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kincaid", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kincardine", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kincolith", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kindersley", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "King City", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kingfisher Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kingfisher Lake First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kingsbury", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Kingsey Falls", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Kingston", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Kingston", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kingsville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "King`s Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "King`s Point", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Kinistino", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kinmount", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kintore", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kinuso", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Kipling", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kippens", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Kirkfield", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kirkland", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Kirkland Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kirkton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kisbey", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kitchener", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Kitimat", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kitkatla", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kitsault", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kitscoty", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Kitwanga", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Kleinburg", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Klemtu", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Knowlton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Kugluktuk", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Kuujjuaq", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Kyle", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Kyuquot", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "La Baie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Broquerie", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "La Corne", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Crete", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "La Dore", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Grande", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Guadeloupe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Loche", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "La Malbaie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Martre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Minerve", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Patrie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Plaine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Pocatiere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Prairie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Reine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Romaine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Ronge", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "La Sarre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "La Scie", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "La Tuque", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Labelle", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Labrador City", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Lac Brochet", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Lac du Bonnet", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Lac Kenogami", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac La Biche", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Lac la Croix", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lac la Hache", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Lac Seul First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lac-au-Saumon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-aux-Sables", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-Bouchette", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-Brome", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-Delage", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-des-Ecorces", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-Drolet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-du-Cerf", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-Edouard", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-Etchemin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-Frontiere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-Poulin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-Saguay", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-Sergent", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lac-St-Joseph", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lachenaie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lachine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lachute", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lacolle", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lacombe", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Ladle Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Ladysmith", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Lafleche", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lafontaine", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lafontaine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lagoon City", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "LaHave", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Laird", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lake Alma", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lake Charlotte", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Lake Cowichan", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Lake Lenore", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lake Louise", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Lake Megantic", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lakefield", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lamaline", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Lambeth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lambton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lameque", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Lamont", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Lampman", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lanark", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lancaster", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Landis", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lang", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Langara", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Langdon", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Langenburg", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Langham", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Langley", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Langruth", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Langton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lanigan", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lanoraie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lansdowne", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lansdowne House", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lantzville", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Larder Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lark Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Larrys River", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "LaSalle", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "LaSalle", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lashburn", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Latchford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Laterriere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Latulipe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Laurentides", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Laurier-Station", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Laurierville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Laval", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Laval des Rapides", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Laval Ouest", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lavaltrie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Laverlochere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lavoy", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Lawn", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Lawrencetown", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Lawrenceville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Le Bic", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Le Gardeur", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Leader", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Leaf Rapids", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Leamington", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Leask", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lebel-sur-Quevillon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Leclercville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Leduc", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Lefroy", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Legal", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Lemberg", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "LeMoyne", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lennoxville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Leoville", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Leroy", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lery", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Les Boules", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Les Cedres", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Les Coteaux", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Les Eboulements", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Les Escoumins", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Les Mechins", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Leslieville", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Lestock", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lethbridge", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Levack", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Levis", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lewisporte", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Libau", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Liberty", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Likely", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Lillooet", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Limerick", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lincoln", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lindsay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lintlaw", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Linwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lion`s Head", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lipton", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Listowel", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Little Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Little Bay Islands", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Little Britain", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Little Burnt Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Little Catalina", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Little Current", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Little Fort", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Little Grand Rapids", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Little Heart`s Ease", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Lively", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Liverpool", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Lloydminster", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Lloydminster", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lockeport", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Lockport", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Lodgepole", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Logan Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Logy Bay-Middle Cove-Outer Cov", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Lombardy", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lomond", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "London", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Long Harbour-Mount Arlington H", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Long Lac", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Long Lake First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Long Point", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Long Pond", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Long Sault", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Longlac", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Longueuil", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Longview", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Loon Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Loos", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Loreburn", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Loretteville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lorne", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lorraine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lorrainville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lougheed", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Louisbourg", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Louisdale", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Louiseville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lourdes", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Lourdes de Blanc Sablon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Louvicourt", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Low", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lower Island Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Lower Post", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Lucan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Luceville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lucknow", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lucky Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lumby", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Lumsden", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Lumsden", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Lundar", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Lunenburg", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Luseland", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Luskville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lyn", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lynden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Lynn Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Lyster", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Lytton", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "L`Acadie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Ancienne-Lorette", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Ange-Gardien", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Annonciation", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Anse-au-Loup", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "L`Ardoise", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "L`Assomption", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Avenir", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Epiphanie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Ile-Aux-Noix", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Ile-Bizard", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Ile-Cadieux", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Ile-Dorval", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Ile-d`Entree", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Ile-Perrot", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Île-Verte", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Islet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "L`Orignal", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ma-Me-O Beach", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Maberly", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mabou", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Macamic", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Maccan", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Macdiarmid", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Maces Bay", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "MacGregor", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Mackenzie", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Macklin", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Macrorie", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "MacTier", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Madoc", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Madsen", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mafeking", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Magnetawan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Magnetawan First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Magog", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Magrath", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Mahone Bay", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Maidstone", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Maidstone", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Main Brook", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Maitland", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Maitland", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Makkovik", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Malartic", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mallorytown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Malton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Manic-Cinq", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Manigotagan", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Manitou", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Manitouwadge", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Manitowaning", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Maniwaki", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mankota", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Manning", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Mannville", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Manor", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Manotick", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Manouane", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Manseau", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mansonville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Manyberries", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Maple", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Maple Creek", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Maple Grove", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Maple Ridge", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Marathon", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Marcelin", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Margaree Forks", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Margo", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Maria", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Marieville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Marion Bridge", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Markdale", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Markham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Markstay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Marlboro", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Marmora", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Marquis", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Marsden", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Marsh Lake", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Marshall", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Marsoui", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Marten Falls First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Marten River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Martensville", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Martintown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Marwayne", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Maryfield", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Marystown", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Mary`s Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Mascouche", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Maskinonge", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Masset", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Massey", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Massey Drive", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Masson-Angers", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Massueville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mastigouche", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Matachewan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Matagami", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Matane", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Matapedia", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Matheson", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mattawa", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mattice", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Maxville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mayerthorpe", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Maymont", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Maynooth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mayo", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "McAdam", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "McAuley", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "McBride", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "McCreary", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "McDonalds Corners", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "McGregor", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "McIver`s", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "McKellar", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "McLeese Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "McLennan", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "McLeod Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Mcmasterville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Meacham", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Meadow Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Meaford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Meander River", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Meath Park", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Medicine Hat", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Meductic", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Melbourne", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Melbourne", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Melfort", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Melita", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Mellin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Melocheville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Melrose", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Melville", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Memramcook", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Meota", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Mercier", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Merigomish", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Merlin", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Merrickville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Merritt", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Metabetchouan", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Metcalfe", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Meteghan", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Metis-sur-Mer", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Miami", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Mica Creek", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Midale", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Middle Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Middleton", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Midland", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Midway", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Milden", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Mildmay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Milestone", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Milford Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Milk River", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Millbrook", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Millertown", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Millet", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Millhaven", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Milltown-Head of Bay D`Espoir", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Millville", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Milo", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Milton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Milverton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Minaki", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Minburn", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Mindemoya", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Minden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mine Centre", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ming`s Bight", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Miniota", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Minnedosa", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Minto", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Minto", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Minton", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Mirabel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Miramichi", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Mirror", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Miscou Island", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Missanabie", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mission", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Mississauga", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mistassini", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mistatim", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Mitchell", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mohawks Of The Bay of Quinte F", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Moisie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Molanosa", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Monastery", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Moncton", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Monkstown", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Monkton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mont Bechervaise", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mont St Grégoire", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mont-Joli", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mont-Laurier", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mont-Louis", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mont-Rolland", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mont-Royal", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mont-St-Hilaire", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mont-St-Pierre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Mont-Tremblant", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Montague", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Montebello", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Montmagny", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Montmartre", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Montney", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Montreal", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Montreal - Est", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Montréal - Nord", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Montréal - Ouest", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Moonbeam", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Moonstone", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mooretown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Moose Creek", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Moose Factory", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Moose Jaw", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Moose Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Moosomin", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Moosonee", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Morden", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Morell", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Morin-Heights", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Morinville", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Morley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Morrin", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Morris", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Morrisburg", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Morse", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Morson", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mortlach", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Mossbank", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Mount Albert", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mount Brydges", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mount Carmel-Mitchells Brook-S", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Mount Forest", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mount Hope", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mount Moriah", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Mount Pearl", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Mount Pleasant", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Mount Stewart", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Mount Uniacke", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Moyie", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Mulgrave", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Mulhurst", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Muncho Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Mundare", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Murdochville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Murray River", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Musgrave Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Musgravetown", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Muskoka", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Muskoka Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Muskrat Dam", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Muskrat Dam First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Musquodoboit Harbour", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Mutton Bay", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Myrnam", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "M`Chigeeng", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nackawic", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Nahanni Butte", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Naicam", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Nain", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Nairn", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Naiscoutaing First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nakina", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nakusp", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Namao", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Nampa", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Nanaimo", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Nantes", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Nanticoke", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nanton", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Napanee", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Napierville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Naramata", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Natashquan", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Navan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nedelec", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Neepawa", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Neguac", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Neidpath", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Neilburg", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Nelson", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Nelson House", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Nepean", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nephton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nestor Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Neudorf", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Neustadt", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Neuville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Neville", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "New Aiyansh", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "New Carlisle", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "New Dayton", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "New Denmark", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "New Denver", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "New Dundee", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "New Germany", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "New Glasgow", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "New Glasgow", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "New Hamburg", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "New Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "New Haven", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "New Liskeard", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "New London", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "New Norway", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "New Perlican", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "New Richmond", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "New Ross", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "New Sarepta", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "New Tecumseth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "New Waterford", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "New Westminster", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "New-Wes-Valley", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Newbrook", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Newburgh", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Newcastle", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Newdale", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Newmarket", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Newport", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Newtonville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Niagara Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Niagara-on-the-Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nickel Centre", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nicolet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Nimpo Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Nipawin", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Nipigon", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nipissing First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nippers Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Nisku", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Niton Junction", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Niverville", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Nobel", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nobleford", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Nobleton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Noel", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Noelville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Nokomis", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Norbertville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Nordegg", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Norman Wells", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Normandin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Norman`s Cove-Long Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Normetal", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Norquay", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Norris Arm", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "North Augusta", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "North Battleford", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "North Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "North Gower", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "North Hatley", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "North Portal", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "North Saanich", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "North Spirit Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "North Sydney", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "North Vancouver", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "North West River", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "North York", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Northbrook", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Northern Arm", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Norton", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Norval", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Norway House", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Norwich", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Norwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Notre Dame de Bonsecours", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre Dame de Lourdes", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Notre Dame de Lourdes", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre Dame De L`Ile Perrot", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre Dame des Laurentides", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre Dame Des Prairies", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre Dame Du Portage", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre-Dame-de-la-Paix", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre-Dame-de-la-Salette", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre-Dame-de-Stanbridge", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre-Dame-du-Bon-Conseil", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre-Dame-du-Lac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre-Dame-du-Laus", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Notre-Dame-du-Nord", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Nouvelle", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Oak Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Oak Ridges", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oak River", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Oakville", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Oakville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oakwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oba", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ocean Falls", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Ocean Park", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Ochre River", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Odessa", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Odessa", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Ogema", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Ogoki", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ohsweken", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oil Springs", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ojibways of Hiawatha First Nat", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ojibways of Walpole Island Fir", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oka", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Okanagan Falls", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Okotoks", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Old Crow", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Old Perlican", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Olds", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Oliver", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Omemee", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Omerville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Onaping Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oneida First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Onoway", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Opasatika", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ophir", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Orangeville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Orford", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Orillia", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Orleans", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ormiston", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Ormstown", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Oro", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oromocto", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Orono", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Orrville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Osgoode", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oshawa", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Osler", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Osoyoos", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Ottawa", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Otterburn Park", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Otterville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Outlook", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Outremont", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Owen Sound", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oxbow", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Oxdrift", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oxford", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Oxford House", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Oxford Mills", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Oyama", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Oyen", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "O`Leary", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Packs Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Pacquet", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Paddockwood", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Paisley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pakenham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Palgrave", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Palmarolle", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Palmer Rapids", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Palmerston", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pangman", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Papineauville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Paquette Corner", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Paquetville", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Paradise", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Paradise Hill", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Paradise River", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Paradise Valley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Parent", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Parham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Paris", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Parkhill", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Parksville", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Parrsboro", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Parry Sound", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Parson", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Pasadena", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Pass Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Patuanak", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Paynton", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Peace River", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Peachland", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Peawanuck", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Peerless Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Peers", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Pefferlaw", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Peggy`s Cove", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Peguis", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pelee Island", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pelham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pelican Narrows", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Pelican Rapids", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pelly", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Pelly Crossing", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Pemberton", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Pembroke", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Penetanguishene", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Penhold", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Pennant", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Pense", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Penticton", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Perce", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Perdue", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Peribonka", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Perkins", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Perrault Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Perth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Perth-Andover", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Petawawa", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Peterborough", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Peterview", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Petit Rocher", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Petitcodiac", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Petite-Riviere-St-Francois", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Petrolia", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Petty Harbour-Maddox Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Philipsburg", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Piapot", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Pickering", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pickle Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Picton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pictou", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Picture Butte", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Pierceland", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Pierrefonds", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pierreville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pikangikum First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pikwitonei", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pilot Butte", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Pilot Mound", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pinawa", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pincher Creek", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Pincourt", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pine Dock", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pine Falls", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pine River", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pineal Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pinehouse", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Piney", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pintendre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pitt Meadows", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Placentia", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Plaisance", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Plamondon", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Plantagenet", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Plaster Rock", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Plate Cove East", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Plato", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Plattsville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pleasant Park", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Plenty", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Plessisville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Plevna", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Plum Coulee", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Plumas", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pohenegamook", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Point Grondine First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Point Leamington", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Point Pelee", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pointe au Baril", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pointe Aux Trembles", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pointe du Bois", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Pointe-a-la-Croix", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pointe-au-Pere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pointe-aux-Outardes", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pointe-Calumet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pointe-Claire", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pointe-des-Cascades", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pointe-des-Monts", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pointe-Fortune", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pointe-Lebel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ponoka", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Pont-Rouge", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pont-Viau", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ponteix", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Pontiac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Pool`s Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Poplar River", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Poplarfield", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Porcupine Plain", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Port Alberni", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Port Alice", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Port au Choix", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Port au Port West-Aguathuna-Fe", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Port Aux Basques", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Port Bickerton", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Port Blandford", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Port Burwell", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Carling", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Clements", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Port Colborne", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Coquitlam", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Port Credit", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Cunnington", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Dover", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Dufferin", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Port Edward", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Port Elgin", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Port Elgin", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Franks", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Greville", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Port Hardy", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Port Hawkesbury", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Port Hood", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Port Hope", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Hope Simpson", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Port La Tour", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Port Lambton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Loring", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Maitland", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Port McNeill", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Port McNicoll", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Mellon", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Port Moody", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Port Morien", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Port Mouton", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Port Perry", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Renfrew", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Port Rexton", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Port Robinson", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Rowan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Saunders", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Port Stanley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Sydney", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Port Union", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Port-Cartier", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Port-Daniel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Port-Menier", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Portage la Prairie", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Portage-du-Fort", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Portland", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Portneuf", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Portugal Cove-St. Philip`s", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Poste-de-la-Baleine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Postville", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Pouce Coupe", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Pouch Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Powassan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Powell River", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Preeceville", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Prelate", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Prescott", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Prespatou", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Preston", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Prevost", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Price", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Prince Albert", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Prince George", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Prince Rupert", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Princeton", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Princeton", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Princeton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Princeville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Prophet River", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Provost", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Prud`homme", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Pubnico", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Puce", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Pugwash", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Punnichy", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Puvirnituq", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Quadra Island", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Qualicum Beach", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Quebec", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Queen Charlotte", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Queensport", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Queenston", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Queensville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Quesnel", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Quill Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Quispamsis", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Quyon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Qu`Appelle", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Rabbit Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Radisson", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Radisson", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Radium Hot Springs", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Radville", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Radway", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Rae", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Rae Lakes", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Rainbow Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Rainy Lake First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rainy River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Raith", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Raleigh", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Ralston", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Ramea", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Ramore", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rankin Inlet", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Rapid City", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Rathwell", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Rawdon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Raymond", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Raymore", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Rayside-Balfour", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Red Bank", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Red Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Red Deer", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Red Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Red Rock", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Red Rock", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Red Sucker Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Redbridge", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Redcliff", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Redditt", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Redvers", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Redwater", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Reefs Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Regina", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Regina Beach", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Remigny", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Rencontre East", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Renfrew", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rennie", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Repentigny", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Réserve faunique de Rimouski", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Réserve faunique la Vérendrye", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Réserves fauniques de Matane e", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Resolute", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Reston", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Restoule", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Revelstoke", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Rhein", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Riceton", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Richelieu", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Richibucto", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Richmond", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Richmond", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Richmond", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Richmond Hill", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Richmound", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Ridgedale", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Ridgetown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ridgeway", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rigaud", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Rigolet", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Rimbey", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Rimouski", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Rimouski-Est", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Riondel", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Ripley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ripon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Riske Creek", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "River Hebert", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "River John", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "River of Ponds", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Riverhurst", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Riverport", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Rivers", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Riverton", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Riverview", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Riviere-a-Pierre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Riviere-au-Renard", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Riviere-au-Tonnerre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Riviere-Beaudette", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Riviere-Bleue", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Riviere-du-Loup", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Riviere-Heva", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Riviere-St-Jean", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Robb", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Robertsonville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Robert`s Arm", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Roberval", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Roblin", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Rocanville", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Rochebaucourt", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Rochester", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Rock Creek", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Rock Forest", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Rockglen", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Rockland", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rockwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rocky Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Rocky Mountain House", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Rockyford", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Roddickton", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Rodney", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rogersville", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Roland", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Rolla", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Rollet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Rolling Hills", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Rolphton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rondeau", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rorketon", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Rosalind", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Rose Blanche-Harbour Le Cou", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Rose Valley", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Rosebud", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Rosemere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Roseneath", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rosetown", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Ross River", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Rossburn", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Rosseau", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rossland", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Rosthern", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Rothesay", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Rougemont", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Rouleau", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Rouyn-Noranda", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Roxboro", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Roxton Falls", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Roxton Pond", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Rumsey", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Rushoon", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Russell", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Russell", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rusticoville", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Ruthven", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Rycroft", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Ryley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Saanich", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sabrevois", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sachigo First Nation Reserve 1", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sackville", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Sacre Coeur", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Alexandre D`Iberville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Alphonse de Granby", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Amable", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Andrews", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Saint Antoine Des Laurentides", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Antoine Sur Richelieu", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Antonin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Athanase", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Calixte", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Charles Borromee", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Charles Sur Richelieu", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Christophe D`Arthabaska", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Clair Beach", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Saint Colomban", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Denis De Brompton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Denis Sur Richelieu", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Esprit", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Etienne de Beauharnois", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Etienne de Lauzon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Gerard Majella", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Isidore de la Prairie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Jean Baptiste", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Jean D`Orleans", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Joachim", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint John", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Saint Joseph De La Pointe De L", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Laurent D`Orleans", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Lazare De Vaudreuil", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Lin Laurentides", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Marc Sur Richelieu", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Mathias Sur Richelieu", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Mathieu de Beloeil", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Mathieu de la Prairie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Maurice", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Norbert D`Arthabaska", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Paul D`Industrie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Philippe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Pierre D`Orleans", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Robert", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Roch De L`Achigan", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Roch De Richelieu", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Sulpice", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Thomas", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Urbain Premier", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Valere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint Victoire de Sorel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint-Alexis-de-Montcalm", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint-Côme", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint-Donat", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint-Élie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint-Élie-d`Orford", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint-Ferdinand", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint-Ferréol-les-neiges", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint-Hubert", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint-Hyacinthe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Saint-Michel-des-Saints", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sainte Angele De Monnoir", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sainte Ann De Sorel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sainte Brigide D`Iberville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sainte Cecile De Milton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sainte Dorotheé", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sainte Famille", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sainte Marie Salome", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sainte Marthe Du Cap", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sainte Sophie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sainte Therese De Blainville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Salaberry-de-Valleyfield", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Salem", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Salisbury", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Salluit", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Salmo", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Salmon Arm", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Salmon Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Salmon Valley", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Salt Springs", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Saltcoats", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Salvage", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Sandspit", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sandwich", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sandy Bay", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Sandy Cove Acres", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sandy Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Sandy Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sandy Lake First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sanford", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Sangudo", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Sanmaur", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sapawe", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sarnia", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Saskatchewan River Crossing", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Saskatoon", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Sauble Beach", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Saugeen First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Saulnierville", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Sault Ste. Marie", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sault-au-Mouton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Savant Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Savona", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sawyerville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sayabec", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sayward", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Scarborough", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sceptre", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Schefferville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Schomberg", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Schreiber", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Schuler", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Scotland", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Scotstown", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Scott", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Seaforth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Seal Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Searchmont", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Seba Beach", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Sebright", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sebringville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sechelt", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sedgewick", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Sedley", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Seeleys Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Selby", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Seldom-Little Seldom", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Selkirk", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Selkirk", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Semans", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Senneterre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Senneville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sept-Iles", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Serpent River First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Seven Persons", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Severn Bridge", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sexsmith", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Shakespeare", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Shalalth", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Shamattawa", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Shannonville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sharbot Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Shaunavon", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Shawanaga First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Shawbridge", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Shawinigan", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Shawinigan-Sud", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Shawville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Shebandowan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Shedden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Shediac", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Shefford", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sheho", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Shelburne", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Shelburne", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Shell Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Shellbrook", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Sherbrooke", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Sherbrooke", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sherwood Park", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Shigawake", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Shilo", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Shippagan", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Shipshaw", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Shoal Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Shubenacadie", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Sibbald", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Sicamous", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sidney", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sidney", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Sifton", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Sillery", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Silver Valley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Silver Water", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Simcoe", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Simpson", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Sintaluta", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Sioux Lookout", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sioux Narrows", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Six Nations of the Grand River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Skookumchuck", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Slave Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Slocan", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Small Point-Broad Cove-Blackhe", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Smeaton", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Smiley", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Smith", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Smithers", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Smiths Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Smithville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Smoky Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Smooth Rock Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Snelgrove", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Snow Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Snowflake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Sointula", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sombra", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Somerset", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Sooke", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sorel-Tracy", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sorrento", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Souris", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Souris", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "South Brook", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "South Indian Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "South Lake", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "South Mountain", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "South River", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "South River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "South Slocan", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Southampton", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Southampton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Southend", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Southern Harbour", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Southey", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Spalding", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Spaniard`s Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Spanish", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sparta", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sparwood", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Speers", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Spencerville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Spences Bridge", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sperling", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Spillimacheen", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Spirit River", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Spiritwood", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Split Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Spotted Island", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Sprague", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Springdale", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Springfield", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Springfield", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Springhill", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Springside", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Spruce Grove", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Spruce View", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Sprucedale", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Spy Hill", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Squamish", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Squatec", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Adelphe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Adolphe-de-Dudswell", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Adolphe-d`Howard", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Agapit", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Aime", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Albert", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Alexandre-de-Kamouraska", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Alexis-de-Matapedia", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Alexis-des-Monts", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Alphonse-Rodriguez", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Andre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Andre-Avellin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Andre-du-Lac-St-Jean", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Andre-Est", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Anselme", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Antoine", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "St-Antoine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Antoine-de-Tilly", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Apollinaire", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Augustin-de-Desmaures", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Barnabe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Barthelemy", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Basile", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "St-Basile-le-Grand", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Basile-Sud", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Blaise-sur-Richelieu", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Boniface-de-Shawinigan", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Bruno", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Bruno-de-Montarville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Calixte-de-Kilkenny", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Casimir", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Celestin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Cesaire", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Charles-de-Bellechasse", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Chrysostome", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Clet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Constant", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Cyrille-de-Wendover", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Damase", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Damien-de-Buckland", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Denis", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Edouard-de-Lotbiniere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Eleuthere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Emile", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Emile-de-Suffolk", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Ephrem-de-Beauce", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Ephrem-de-Tring", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Eugene", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St-Eugene-de-Guigues", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Eustache", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Fabien-de-Panet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Felicien", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Felix-de-Kingsey", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Felix-de-Valois", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Fidele-de-Mont-Murray", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Flavien", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Francois-du-Lac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Fulgence", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Gabriel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Gabriel-de-Brandon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Gedeon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Georges", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Georges-de-Beauce", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Georges-de-Cacouna", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Gerard", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Germain-de-Grantham", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Gregoire-de-Greenlay", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Guillaume", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Hilarion", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Hippolyte", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Honore-de-Beauce", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Honore-de-Chicoutimi", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Hugues", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Irenee", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Isidore", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "St-Jacques", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Jean-Chrysostome", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Jean-de-Dieu", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Jean-de-Matha", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Jean-Port-Joli", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Jean-sur-Richelieu", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Jerome", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Joseph-de-Beauce", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Joseph-de-la-Rive", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Joseph-de-Sorel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Jovite", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Jude", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Just-de-Bretenieres", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Lambert", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Lambert-de-Lauzon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Laurent", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Leon-le-Grand", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Leonard", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Leonard-d`Aston", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Liboire", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Lin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Louis de Kent", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "St-Louis-de-France", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Luc", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Ludger", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Magloire", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Malachie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Malo", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Marc-des-Carrieres", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Methode-de-Frontenac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Michel-de-Bellechasse", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Moose", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Nazaire-d`Acton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Nicolas", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Noel", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Odilon-de-Cranbourne", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Ours", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Pacome", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Pamphile", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Pascal", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Patrice-de-Beaurivage", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Paul-de-Montminy", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Paul-d`Abbotsford", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Paulin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Philippe-de-Neri", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Pie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Pie-de-Guire", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Pierre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Pierre-de-Wakefield", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Pierre-Jolys", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "St-Pierre-les-Becquets", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Polycarpe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Prime", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Prosper-de-Dorchester", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Quentin", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "St-Raymond", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Redempteur", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Remi", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Rene-de-Matane", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Roch-de-Mekinac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Roch-des-Aulnaies", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Romuald", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Sauveur", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Sauveur-des-Monts", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Simeon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Simon-de-Bagot", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Simon-de-Rimouski", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Sylvere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Sylvestre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Theophile", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Thomas-d`Aquin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Timothee", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Tite", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Tite-des-Caps", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Ubalde", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Ulric", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Urbain", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Victor", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Wenceslas", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Zacharie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Zenon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Zephirin", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St-Zotique", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Alban`s", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Albert", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "St. Ambroise de Chicoutimi", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Anthony", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Basile de Portneuf", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Benedict", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "St. Bernard de Dorchester", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Bernard`s-Jacques Fontaine", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Brendan`s", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Bride`s", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Brieux", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "St. Catharines", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St. Charles", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St. Claude", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "St. Clements", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St. Come de Kennebec", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Davids", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St. Edouard de Frampton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Fabien de Rimouski", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Ferdinand d`Halifax", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Fidele", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Francois Xavier", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "St. Gabriel de Rimouski", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Gedeon de Beauce", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. George", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "St. George", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St. George`s", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Gregoire de Nicolet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Gregor", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "St. Henri de Levis", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Honore", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Isidore de Prescott", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St. Jacobs", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St. Jacques-Coomb`s Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Jean Baptiste", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "St. John`s", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Laurent", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "St. Lawrence", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Lazare", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "St. Leon De Chic.", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Leonard", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "St. Lewis", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Louis", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "St. Lunaire-Griquet", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Margaret Village", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "St. Martin de Beauce", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Martins", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "St. Marys", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St. Mary`s", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Michael", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "St. Moise", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Paul", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "St. Peters", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "St. Peter`s", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "St. Raphael de Bellechasse", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Regis", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St. Sebastien", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Stanislas de Champlain", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Stephen", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "St. Theodore de Chertsey", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Thomas", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "St. Victor de Beauce", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Vincent de Paul", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "St. Vincent`s-St. Stephen`s-Pe", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "St. Walburg", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Stand Off", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Standard", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Stanley", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Stanley Mission", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Stanstead", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Star City", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Starbuck", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Stavely", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Stayner", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Ste-Adele", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Agathe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Agathe-des-Monts", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Agathe-Sud", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Anne-de-Beaupre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Anne-de-Bellevue", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Anne-de-la-Perade", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Anne-de-Madawaska", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Ste-Anne-de-Portneuf", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Anne-des-Monts", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Anne-des-Plaines", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Anne-du-Lac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Blandine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Brigitte-de-Laval", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Catherine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Clotilde-de-Horton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Eulalie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Felicite", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Foy", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Genevieve", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Helene-de-Bagot", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Henedine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Jeanne-d`Arc", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Julie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Julie-de-Vercheres", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Julienne", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Justine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Lucie-de-Beauregard", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Madeleine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Marguerite", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Marie-de-Beauce", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Marie-de-Blandford", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Marthe", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Marthe-sur-le-Lac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Perpetue", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Petronille", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Rosalie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Rose", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Rose-de-Watford", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Rose-du-Nord", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Sophie-de-Levrard", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Thecle", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Therese", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Veronique", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste-Victoire", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Agathe", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Ste. Agathe de Lotbiniere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Angele de Laval", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Cecile Masham", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Claire de Dorchester", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Croix de Lotbiniere", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Gertrude", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Justine de Newton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Martine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Methode de Frontenac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Monique de Nicolet", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Ste. Rose du Lac", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Steady Brook", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Steep Rock", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Steinbach", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Stellarton", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Stephenville", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Stephenville Crossing", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Stettler", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Stevensville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Stewart", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Stewarttown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Stewiacke", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Stirling", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Stirling", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Stockholm", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Stoke", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Stoke`s Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Stoneham", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Stonewall", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Stoney Creek", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Stoney Point", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Stony Plain", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Stony Rapids", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Storthoaks", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Stouffville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Stoughton", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Straffordville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Strasbourg", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Stratford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Stratford", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Stratford", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Strathclair", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Strathmore", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Strathroy", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Stratton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Streetsville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Strome", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Strongfield", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Stroud", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Stukely-Sud", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Sturgeon Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sturgis", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Sudbury", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sultan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Summer Beaver", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Summerford", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Summerland", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Summerside", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Summerside", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Summerville", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Summit Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sunderland", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sundre", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Sundridge", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sunnyside", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Surrey", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Sussex", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Sutton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sutton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Swan Hills", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Swan Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Swan River", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Swastika", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Swift Current", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Swift River", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Sydenham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Sydney", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Sylvan Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Taber", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Tabusintac", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Tachie", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Tadoule Lake", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Tadoussac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Tagish", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Tahsis", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Tamworth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Tangier", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Tantallon", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Tara", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Taschereau", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Tasiujaq", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Tatamagouche", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Tatla Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Tavistock", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Taylor", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Taylor Corners", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Tecumseh", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Teeswater", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Telegraph Creek", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Telkwa", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Temagami", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Temiscaming", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Terra Nova", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Terrace", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Terrace Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Terrasse Vaudreuil", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Terrebonne", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Terrenceville", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Teslin", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Tete-a-la-Baleine", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Teulon", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Thamesford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Thamesville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "The Eabametoong (Fort Hope) Fi", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "The Pas", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Thedford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Theodore", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Thessalon", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Thessalon First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Thetford Mines", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Thicket Portage", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Thompson", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Thorburn", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Thorhild", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Thornbury", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Thorndale", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Thorne", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Thornhill", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Thorold", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Thorsby", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Three Hills", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Thrums", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Thunder Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Thurlow", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Thurso", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Tignish", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Tilbury", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Tilley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Tillsonburg", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Timmins", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Tingwick", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Tisdale", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Tiverton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Toad River", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Tobermory", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Tobique First Nation", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Tofield", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Tofino", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Togo", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Toledo", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Tomahawk", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Tompkins", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Topley", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Torbay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Toronto", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Toronto Island", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Torquay", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Torrington", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Tottenham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Tracadie-Sheila", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Trail", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Tramping Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Treherne", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Tremblay", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Trenton", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Trenton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Trepassey", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Tribune", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Tring-Jonction", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Triton", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Trochu", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Trois-Pistoles", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Trois-Rivieres", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Trout Creek", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Trout Lake", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Trout Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Trout Lake", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Trout River", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Trowbridge", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Truro", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Tsay Keh Dene", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Tsiigehtchic", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Tuktoyaktuk", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Tumbler Ridge", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Turner Valley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Turnor Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Turtleford", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Tusket", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Tweed", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Twillingate", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Two Hills", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Tyne Valley", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Ucluelet", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Udora", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Umiujaq", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Uniondale", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Unionville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Unity", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Upper Island Cove", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Upper Musquodoboit", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Upper Stewiacke", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Upsala", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Upton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Uranium City", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Utterson", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Uxbridge", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Val Marie", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Val-Alain", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Val-Barrette", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Val-Belair", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Val-Brillant", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Val-David", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Val-des-Bois", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Val-d`Or", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Valcartier", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Valcourt", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Valemount", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Vallee-Jonction", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Valley East", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Valleyview", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Vallican", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Van Anda", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Vancouver", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Vanderhoof", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Vanguard", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Vanier", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Vanier", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Vankleek Hill", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Vanscoy", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Varennes", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Vaudreuil", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Vaudreuil Dorion", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Vaudreuil-sur-le-Lac", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Vaughan", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Vauxhall", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Vavenby", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Vegreville", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Venise-en-Quebec", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Vercheres", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Verdun", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Vermilion", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Vermilion Bay", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Verner", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Vernon", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Vernon River", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Verona", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Veteran", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Vibank", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Victoria", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Victoria", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Victoria", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Victoriaville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "View Royal", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Viking", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Ville-Marie", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Vilna", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Vimont", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Vineland", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Virden", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Virginiatown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Viscount", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Vita", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Vonda", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Vulcan", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Waasagomach", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Wabamun", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Wabana", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Wabigoon", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wabowden", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Wabush", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Wadena", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Wainfleet", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wainwright", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Wakaw", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Wakefield", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Walden", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Waldheim", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Walkerton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wallace", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Wallaceburg", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Walsh", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Walton", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Wandering River", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Wanham", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Wanless", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Wapekeka First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wapella", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Warburg", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Warden", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Wardsville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Warkworth", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Warman", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Warner", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Warren", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Warspite", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Warwick", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Wasaga Beach", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wasagaming", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Waskaganish", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Waskatenau", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Waskesiu Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Waswanipi", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Waterdown", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Waterford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Waterhen", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Waterloo", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Waterloo", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Waterville", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Watford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Watrous", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Watson", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Watson Lake", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Waubaushene", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Waverley", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Wawa", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wawanesa", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Wawota", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Webb", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Webbwood", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Webequie", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wedgeport", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Weedon", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Weedon Centre", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Welcome", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Welland", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wellandport", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wellesley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wellington", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wellington", "Prince Edward Island"
            ),
            new KeyValuePair<string,string>(
                "Wells", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Welsford", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Welwyn", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Wembley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Wemindji", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Wendover", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Wesleyville", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "West Brome", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "West Guilford", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "West Lincoln", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "West Lorne", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "West Vancouver", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Westbank", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Westbury", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Western Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Westfield", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Westlock", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Westmeath", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Westmount", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Westport", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Westport", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Westree", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Westville", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Westwold", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Wetaskiwin", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Weyburn", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Weymouth", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Whale Cove", "Nunavut"
            ),
            new KeyValuePair<string,string>(
                "Wheatley", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Whistler", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Whitbourne", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Whitby", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Whitchurch-Stouffville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "White Fox", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "White River", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "White Rock", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Whitecourt", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Whitefish", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Whitefish Falls", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Whitefish River First Nation", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Whitehorse", "Yukon"
            ),
            new KeyValuePair<string,string>(
                "Whitelaw", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Whitemouth", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Whitewood", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Whitney", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Whycocomagh", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Wiarton", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wickham", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Widewater", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Wikwemikong", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wilberforce", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wilcox", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Wildwood", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Wilkie", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Williams Lake", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Williamsburg", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Willingdon", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Willow Bunch", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Willowbrook", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Winchester", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Windermere", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Windsor", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Windsor", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Windsor", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Windthorst", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Winfield", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Winfield", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Wingham", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Winkler", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Winnipeg", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Winnipeg Beach", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Winnipegosis", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Winona", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Winter Harbour", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Winterton", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Wiseton", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Wishart", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Witless Bay", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Woburn", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Woking", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Wolfville", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Wollaston Lake", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Wolseley", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Wonowon", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Wood Mountain", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Woodbridge", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Woodridge", "Manitoba"
            ),
            new KeyValuePair<string,string>(
                "Woodstock", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Woodstock", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Woodville", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Woody Point", "Newfoundland and Labrador"
            ),
            new KeyValuePair<string,string>(
                "Wooler", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Worsley", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Wotton", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Wrentham", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Wrigley", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "Wunnummin Lake", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Wynndel", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Wynyard", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Wyoming", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Yahk", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Yale", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Yamachiche", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Yamaska", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Yamaska-Est", "Quebec"
            ),
            new KeyValuePair<string,string>(
                "Yarker", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Yarmouth", "Nova Scotia"
            ),
            new KeyValuePair<string,string>(
                "Yellow Creek", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Yellow Grass", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Yellowknife", "Northwest Territories"
            ),
            new KeyValuePair<string,string>(
                "York", "Ontario"
            ),
            new KeyValuePair<string,string>(
                "Yorkton", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Youbou", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Young", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Youngstown", "Alberta"
            ),
            new KeyValuePair<string,string>(
                "Young`s Cove Road", "New Brunswick"
            ),
            new KeyValuePair<string,string>(
                "Zealandia", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Zeballos", "British Columbia"
            ),
            new KeyValuePair<string,string>(
                "Zenon Park", "Saskatchewan"
            ),
            new KeyValuePair<string,string>(
                "Zurich", "Ontario"
            )
        };
    }
}