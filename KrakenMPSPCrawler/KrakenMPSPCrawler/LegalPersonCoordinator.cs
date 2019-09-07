﻿using KrakenMPSPCrawler.Models;
using KrakenMPSPCrawler.Business;
using KrakenMPSPCrawler.Business.Model;
using KrakenMPSPCrawler.Crawlers;

namespace KrakenMPSPCrawler
{
    public class LegalPersonCoordinator : Coordinator
    {
        public LegalPersonCoordinator(LegalPersonModel legalPerson)
        {
            // Classe de Crawler base, apenas duplique
            // AddModule(new ExampleCrawler("julio+cesar"));

            AddModule(new ArispCrawler(legalPerson.Type, legalPerson.CNPJ));
        }
    }
}
