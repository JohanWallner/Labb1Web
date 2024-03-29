﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Services
{
    public class MockProductService : IProductService
    {
        public List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = Guid.NewGuid(),
                Description = "Hemmets Journal är Sveriges ledande veckotidning som varje vecka ger dig mycket att läsa. I våra reportage möter du spännande människor, både kända och okända. Du får rolig, gripande engagerande läsning som berör.Spännande  artiklar om hälsa och medicinska nyheter. Hemmets Journal har Sveriges bästa kryss! Varje vecka får du minst 16 sidor där de allra skickligaste konstruktörerna bjuder på en härlig blandning från lätt till riktigt svårt. VÅR BÄSTA MAT heter vår matbilaga som är en guldgruva för dig som gillar mat. Du får också massor av tips för dig själv och ditt hem på tidningens sidor för mode, skönhet, inredning och trädgård.",
                Name = "Hemmets Journal",
                Price = 169M,
                ImgSrc = "https://bilder.tidningskungen.se/upl/normal300/hemmets-journal-9-2020.jpg"
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                Description = "Börja prenumerera på Bamse till kampanjpris och följ med Bamse och hans vänner på mängder av spännande äventyr i varje nummer. Bamse är en klassiker och alltid en uppskattad present till de yngre!\n\nBamse är världens starkaste Björn och tillsammans med sina vänner som Skalman, Lille skutt och farmor som gör den magiska dunderhonungen så händer det alltid massor av spännande saker. Bamse är en riktig klassiker som är mycket populär hos de yngre och har varit det ända sedan 1966 då serien startade. Förutom underhållande läsning och serier så innehåller varje nummer av Bamse massor av pyssel, tävlingar och ibland även en överraskning som en affisch, klistermärke eller något annat kul. Utöver detta så kan man även lära sig nya saker i Bamses alldeles egna mycket uppskattade skola.\n\nEn prenumeration på Bamse är en uppskattad present eller julklapp till de yngre. Tidningen Bamse utkommer med 20 nummer per år och är på Svenska! \n\nFörlaget delar ut ett par dubbelnummer varje år. Ett dubbelnummer är tjockare än en vanlig utgåva och avser 2 utgåvor i prenumerationen.",
                Name = "Bamse",
                Price = 159M,
                ImgSrc = "https://bilder.tidningskungen.se/upl/normal300/bamse-tidningsprenumeration-3-2020.jpg"
            },
            new Product()
        {
            Id = Guid.NewGuid(),
                Description = "Varje vecka kommer spännande och roliga äventyr med Kalle Anka och hans vänner direkt hem i din brevlåda. Förutom de förstklassiga serierna, finns varje vecka tävlingar med fina priser, Deckargåtan, Tips & Tricks och mycket mer.\n\n\nDe spännande och roliga serierna ger barn en skön och rolig stund som motvikt till många barns allt mer stressade tillvaro. Barn som läser serier utvecklar sin läsförmåga och sitt språk. Något de har nytta av hela livet! Men framförallt – så har de roligt! Kalle Anka utkommer med 52 nummer per år och är på svenska.",
                Name = "Kalle Anka & C:o",
                Price = 227M,
                ImgSrc = "https://bilder.tidningskungen.se/upl/normal300/kalle-anka--co-tidningsprenumeration-8-2020.jpg"
            },
            new Product()
        {
            Id = Guid.NewGuid(),
                Description = "Min Häst prenumeration\nKänner du någon mellan 7-14 år som fullständigt älskar hästar och allt som har med hästar att göra? Har personen i fråga aldrig stött på denna tidning tidigare? Du har nu lyckats finna alla hästälskares största skatt – En prenumeration på tidningen Min Häst!\n\nMed en prenumeration på magasinet Min Häst blir läsarens tillvaro förgylld med hela 26 nr varje år då tidningen delas ut varannan vecka, året om. 6 stycken tidningar är extratjocka specialnummer med extra mycket roligt att läsa om. \n\nVarje tidning är full med vackert ritade hästserier som tar med oss på härliga och spännande äventyr. I varje utgåva från läsaren också pedagogiskt upplagda faktasidor, roliga och läsvärda artiklar och fina affischer. Det finns även en plats i tidningen som kallas för \"läsarsidor\". Dessa sidor tillåter tidningens unga prenumeranter att ställa frågor och dela med sig av fängslande upplevelser och berättelser. \n\nMin Häst är tidningen som bjuder på en salig samling av sådant som känns roligt, sorgligt, mysigt, spännande och lärorikt. När du beställer via oss på Tidningskungen.se ingår även den digitala versionen av tidningen. Detta gör att prenumeranten kan läsa tidningen vart som helst, när som helst! \n\nMin Häst mulle\nNaturligtvis kommer hästen Mulle alltid finnas på plats med härliga tips och råd för alla hästälskare! Köp en gåva som håller länge! En prenumeration på Sveriges största hästtidning för barn! \n\nFörlaget delar ut ett par dubbelnummer varje år. Ett dubbelnummer är tjockare än en vanlig utgåva och avser 2 utgåvor i prenumerationen.",
                Name = "Min häst",
                Price = 188M,
                ImgSrc = "https://bilder.tidningskungen.se/upl/normal300/min-hast-6-2020.jpg"
            },
            new Product()
        {
            Id = Guid.NewGuid(),
                Description = "Prenumerera på Kamratposten\nKamratposten firar nu 125 år och har varit en vän att lita på för miljontals barn och unga. \nKP står alltid på barnens sida och barnen själva är med och bidrar till tidningen med insändare, teckningar och framför allt smarta frågor! \n\nI Kamratposten är barnens behov av både kul och meningsfull läsning i fokus och vi riktar oss precis lika mycket till killar som till tjejer. \nFör ALLA barn är värda en schysst, rolig och spännande tidning!\n\nKamratposten passar alla åldrar – både barn och unga vuxna\nSom prenumerant på Kamratposten får läsarna ta del av massor med roligt om allt mellan himmel och jord. \nDet kan handla om pinsamheter, reportage om de största idolerna samt andra såväl viktiga som roliga artiklar om vetenskap och aktuella nyheter. \nI varje efterlängtad utgåva lyfter tidningen både frågor och svar från läsarna själva. Det är allt från kärlek och vänskap till frågor om kroppen och knoppen. \nNi vet de frågor som kan vara lite svåra att ställa högt till en vuxen? Kamratposten lyser gärna ljus över de frågor som barn och unga vuxna funderar över. \n\nSedan starten 1892 har Kamratposten funnits till för att främja och stärka barns läsande och självförtroende. \nKamratposten är en oerhört populär barn- och ungdomstidning, helt fri från annonser och som utkommer kontinuerligt var tredje vecka. \nTidningen passar naturligtvis alla åldrar – inte bara barn och ungdomar.\n\nKamratposten erbjudande\nGör någon glad och ge bort en prenumeration på Kamratposten redan i dag! Spara upp till 48% när du väljer en prenumeration på kamratposten hos oss på Tidnigskungen.",
                Name = "Kamratposten",
                Price = 135M,
                ImgSrc = "https://bilder.tidningskungen.se/upl/normal300/kamratposten-2-2020.jpg"
            },
            new Product()
        {
            Id = Guid.NewGuid(),
                Description = "Allas veckotidning\nAllas är en tidning för kvinnan mitt uppe i livet – färgstark och spännande.\n\nVi lagar fräsch och läcker mat – och som prenumerant får du såklart ta del av Allas recept. Matinspiration både vardags och till de lite mer festliga tillställningarna. Du får också praktiska tips om heminredning, krukväxter och trädgård, mode och skönhet, handarbeten och hobby.\n\nAllas prenumeration\nSom prenumerant får du även ta del av mycket innehåll om kärlek, relationer, kvinnors hälsa och annat som ligger dig varmt om hjärtat. Du får fängslande romaner, noveller och läsarnas egna berättelser. Starka och engagerande reportage som både roar och berör. Dessutom får du tillgång till Allas korsord - både lätta och kluriga kryss att koppla av med.",
                Name = "Allas",
                Price = 99M,
                ImgSrc = "https://bilder.tidningskungen.se/upl/normal300/allas-8-2020-2.jpg"
            },
            new Product()
        {
            Id = Guid.NewGuid(),
                Description = "Sveriges största veckotidning ger dig glädje och inspiration, varje vecka. Allers skriver om vardagens hjältar och hjältinnor, om djur och natur, om nytt och gammalt. Vi bjuder på härliga recept, allt efter årstid. Vi ger dig avkopplande handarbeten och massor av tips och idéer för ditt trivsamma hem. Och vi utmanar dig med Sveriges bästa korsord, alltid på krysspapper och i många olika svårighetsgrader – varje vecka.",
                Name = "Allers",
                Price = 99M,
                ImgSrc = "https://bilder.tidningskungen.se/upl/normal300/allers-9-2020.jpg"
            },
            new Product()
        {
            Id = Guid.NewGuid(),
                Description = "Ingen information tillgänglig",
                Name = "Råd & Rön",
                Price = 45M,
                ImgSrc = "https://bilder.tidningskungen.se/upl/normal300/rad--ron-2-2020.jpg",
            },
            new Product()
        {
            Id = Guid.NewGuid(),
                Description = "Året Runt är tidningen som är som en god vän. Koppla av med massor av spännande läsning varje vecka om både kända och okända intressanta personligheter. Samla alla underbara recept med mat och bak till vardag och fest. Bryr du dig om din hälsa? Vill du klä dig snyggt och piffigt för en liten slant? Gillar du kluriga kryss? Då är Året Runt din tidning.",
                Name = "Året Runt",
                Price = 99M,
                ImgSrc = "https://bilder.tidningskungen.se/upl/normal300/aret-runt-tidningsprenumeration-3-2020.jpg"
            },
            new Product()
        {
            Id = Guid.NewGuid(),
                Description = "Nordens största magasin om natur, vetenskap och teknik. Prenumerera på Illustrerad Vetenskap och låt tidningen ta med dig på en resa i en fascinerande värld av upptäckter och nya rön.\nSedan starten 1984 har Illustrerad Vetenskap passat alla, oavsett ålder, som fascineras av allt spännande som rör vår planet, natur, vetenskap och teknik. Läs om världens ledande forskning inom en mängd olika ämnen och vidga dina perspektiv med mer kunskap om omvärlden. \nTidningens innehåll\nVarje nummer av Illustrerad Vetenskap bjuder på rikt illustrerade artiklar, skrivna på ett levande språk som både fängslar och underhåller. \nSom läsare får du ta del av alla de senaste nyheterna och trenderna inom vetenskapen, samtidigt som du kan läsa artiklar om vad världens främsta ingenjörer för närvarande sysselsätter sig med. \nDessutom är tidningen i allmänhet fullmatad med fakta och förklaringar som rör allt mellan himmel och jord. Om du har några som helst frågor som rör vetenskap så kan du lita på att du hittar svaren i Illustrerad Vetenskap. \nTeckna en tidningsprenumeration\nMed en prenumeration på Illustrerad Vetenskap ser du till att alltid ha koll på det senaste inom ny forskning och vetenskap. \nOm du tecknar en prenumeration kan du dessutom läsa tidningen online, få alla de senaste nyheterna direkt via email samt få bra erbjudanden på både varor i tidningens webbshop och deras resor. \nSå se till att välja Illustrerad Vetenskap till vårt prenumerationspris redan idag! \nPS. Har du en vän som skulle uppskatta en prenumeration? Illustrerad Vetenskap är en av våra bästsäljande gåvor hos Tidningskungen! Klicka på \"Ge bort\" istället för på \"Beställ\" så kan du göra någon lite extra glad idag.",
                Name = "Illustrerad Vetenskap",
                Price = 45M,
                ImgSrc = "https://bilder.tidningskungen.se/upl/normal300/illustrerad-vetenskap-tidningsprenumeration-4-2020.jpg",
            },

    };
        public MockProductService()
        {

        }
        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product GetById(Guid id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            return product;
        }
    }
}
