using UnityEngine;

namespace Assets._SCRIPTS.Story
{
    public class QuestFactory
    {
        private readonly Character _elektrij;
        private readonly Character _aleksiej;
        private readonly Character _borys;
        private readonly Character _dimitrij;
        private readonly Character _elena;
        private readonly Character _igor;
        private readonly Character _ivan;
        private readonly Character _natasza;
        private readonly Character _nikolai;
        private readonly Character _nina;
        private readonly Character _sasza;
        private readonly Character _sergiej;
        private readonly Character _tamara;
        private readonly Character _tatiana;
        private readonly Character _wania;

        public QuestFactory()
        {
            _elektrij = new Character("Elektrij", true);
            _aleksiej = new Character("Aleksiej", false);
            _borys = new Character("Borys", false);
            _dimitrij = new Character("Dimitrij", false);
            _elena = new Character("Elena", false);
            _igor = new Character("Igor", false);
            _ivan = new Character("Ivan", false);
            _natasza = new Character("Natasza", false);
            _nikolai = new Character("Nikolai", false);
            _nina = new Character("Nina", false);
            _sasza = new Character("Sasza", false);
            _sergiej = new Character("Sergiej", false);
            _tamara = new Character("Tamara", false);
            _tatiana = new Character("Tatiana", false);
            _wania = new Character("Wania", false);
        }

        private Quest GetTestQuest(Quest nextQuest)
        {
            DialogLine startLine =
                new DialogLine("- Czesc Dimitrii", _elektrij,
                    new DialogLine("- Spierdalaj", _aleksiej,
                        new DialogChoice("Co chcesz zrobic Dimitriemu", _elektrij,
                            "Zajebac lepe", new DialogLine("* Lepa odjebala Dimitriiowi glowe! *", _aleksiej, null),
                            "Zasadzic luja z calej epy", new DialogLine("- O zesz Ty kurwa!", _aleksiej, null),
                            "Wyjebac z dyni", new DialogLine("* Dimitrii implodowal *", _aleksiej, null)
                        )
                    )
                );

            DialogLine endLine =
                new DialogLine("No i dobrze, ze z dech", _elektrij,
                    new DialogLine("No raczej kurwa nie inaczej", _aleksiej,
                        new DialogLine("No i kurwa pierwszorzednie mordo, elo", _elektrij, null)));

            DialogSequence beginningSequence = new DialogSequence(startLine);
            DialogSequence endingSequence = new DialogSequence(endLine);

            Quest q = new Quest(beginningSequence, endingSequence, nextQuest);
            q.AddDialogSequence("Elena", new DialogSequence(new DialogLine("* Dimitrii implodowal *", _elena, null)));
            return q;
        }

        private Quest GetQuest1(Quest nextQuest)
        {
            DialogLine startLine = null;
            DialogLine endLine = null;

            DialogSequence beginningSequence = new DialogSequence(startLine);
            DialogSequence endingSequence = new DialogSequence(endLine);

            Quest q = new Quest(beginningSequence, endingSequence, nextQuest);
            
            //Borys
            q.AddDialogSequence("Borys", new DialogSequence(
                new DialogLine("Hej! Elektrij! Jak tam zdrowie? Moze napijemy sie razem, mam tu najlepszy towar domowej roboty, hehe.", _borys,
                    new DialogChoice("Odpowiedz", _elektrij,
                        "Nie mam czasu stary chlejusie.", 
                        new DialogLine("A to poshol von! Cyka blyat!", _borys, null),
                        "Niestety ale śpieszę z pomocą ludziom w szpitalu, ale chętnie kupiłbym od Ciebie trochę twojego towaru.", 
                        new DialogLine("Trzymaj tą flachę, woltaż 60%, zwala z nóg. Tylko 500 rubli.", _borys, 
                            new DialogLine("Dzięki brachu, do zobaczenia.", _elektrij, null)),
                        "Borys! Mój najlepszy kompan do picia. Wypijmy za rewolucję!", 
                        new DialogLine("Na zdrovie! ** Wypija setę do dna wychwalając rewolucję **", _elektrij, null)
                    )
                )
            ));

            //Dimitrij
            q.AddDialogSequence("Dimitrij", new DialogSequence(
                new DialogLine("Witaj barcie! Słyszazłeś co się stało?", _dimitrij,
                    new DialogLine("Tak, słyszałem o awarii zasilania w szpitalu i więzieniu. Czy wiesz może, co sie tam stało?", _elektrij,
                        new DialogLine("Tak, powinieneś się tam jak najszybciej udać. Zasilanie inkubatorów uległo awarii. Okablowanie jest w największym pokoju z łóżkami. Śpiesz się, trzeba uratować te dzieci!", _dimitrij,
                            new DialogLine("Dziękuje, przyjacielu!", _elektrij, null)
                            )
                        )
                    )
                )
            );

            //Wania
            q.AddDialogSequence("Wania", new DialogSequence(
                new DialogLine("Cześć Wania!", _elektrij, 
                    new DialogLine("Cześć Elektrij.", _wania,
                        new DialogLine("Czy słyszałeś coś problemach z zasilaniem i więzieniu?", _elektrij, 
                            new DialogLine("Nie.", _wania,
                                new DialogLine("Trudno, bywaj zdrów.", _elektrij, null)
                                )
                            )
                        )
                    )
                )
            );

            //Elena
            q.AddDialogSequence("Elena", new DialogSequence(
                new DialogLine("Elektrij ratuj! Mój syn leży w szpitalu na oddziale intensywnej terapii. Pomóż mu proszę. W szpitalu brakło zasilania i sytuacja ta może spowodować śmierć większości pacjentów!", _elena, 
                    new DialogLine("Spokojnie, właśnie tam zmierzam. Czy wiesz, gdzie znajduje się pomieszczenie, z którego mógłbym dostać się do miejsca awarii?", _elektrij, 
                        new DialogLine("Tak, awaria znajduje się przy stołówce.", _elena, 
                            new DialogLine("Dziękuje Elena. Zrobię wszystko co w mojej mocy.", _elektrij, null)
                            )
                        )
                    )
                )
            );

            //Igor
            q.AddDialogSequence("Igor", new DialogSequence(new DialogLine("Igor nie mieć czasu, Igor kopać węgiel.", _igor, null)));

            //Ivan
            q.AddDialogSequence("Ivan", new DialogSequence(new DialogLine("Nie zawracaj mi głowy!", _ivan, null)));
            
            //Ivan
            q.AddDialogSequence("Nikolai", new DialogSequence(
                new DialogLine("Chwała Carowi! Co Cię Tu sprowadza Elektrij?!", _nikolai, 
                    new DialogLine("Witaj, Nikolai. Czy wiesz coś o awariach w szpitalu i więzieniu.", _elektrij,
                        new DialogLine("Tak. Słyszałem, że spora część więźniów, która leży w więziennym szpitalu umrze, jeżeli ktoś szybko nie naprawi agregatu prądotwórczego.", _nikolai,
                            new DialogLine("Czy wiesz gdzie go znajdę?", _elektrij,
                                new DialogLine("Niestety nie, ale spytaj Saszy, on tam pracuje.", _nikolai,
                                    new DialogLine("Dzięki, bywaj.", _elektrij, null)
                                    )
                                )
                            )
                        )
                    )
                )
            );

            //Nina
            q.AddDialogSequence("Nina", new DialogSequence(new DialogLine("Hej, przystojniaku.", _nina, null)));

            //Sasza
            q.AddDialogSequence("Sasza", new DialogSequence(
                new DialogLine("Witaj, Sasza. Słyszałem, że jest problem z zasilaniem w więzieniu.", _elektrij, 
                    new DialogLine("Witaj, Elektrij. Tak, mamy awarię i te szumowiny uciekną i zaczną znowu zabijać, jeżeli nie naprawisz bramy.", _sasza,
                        new DialogChoice("Odpowiedź", _elektrij,
                            "Czy wiesz gdzie jest zepsuty agregat prądotwórczy zasilający skrzydło szpitalne?", 
                                new DialogLine("Co? Chcesz ratować tych kryminalistów!? W takim razie lepiej nie rób nic, z chęcią ich powystrzelam jak będą próbowali uciekać.", _sasza, null),
                            "Gdzie znajdę okablowanie związane z usterką bramy?", 
                                new DialogLine("Znajdziesz ją jeżeli pójdziesz drogą na lewo od wejścia. Pośpiesz się, bo te szumowiny uciekną i będę musiał zająć się nimi osobiście.", _sasza, null)
                            )
                        )
                    )
                )
            );

            //Sergiej
            q.AddDialogSequence("Sergiej", new DialogSequence(
                new DialogLine("Słuchaj, nie chcesz może zarobić? W więzieniu znajduje się mój... partner biznesowy, a brak zasilania w więzieniu sprawi mi dobrą okazję do odnowienia z nim kontaktu. ", _sergiej, 
                    new DialogLine("Zamiast naprawiać całe zasilanie, idź uruchomić agregat prądotwórczy w sektorze szpitalnym, droga na wprost gdy wejdziesz do środka. Odwdzięczę się, gdy już będzie po wszystkim. Co ty na to?", _sergiej,
                        new DialogChoice("Odpowiedź", _elektrij,
                            "Co dostanę w zamian?", 
                                new DialogLine("Mogę zaoferować Ci pieniądzę lub przysługę. W każdym razie na pewno się nie zawiedziesz, jeśli mi pomożesz.", _sasza,
                                    new DialogChoice("Odpowiedź", _elektrij,
                                        "Zatem niech tak będzie, dług odbiorę po udanej akcji.", 
                                            new DialogLine("Interesy z Tobą to przyjemność.", _sasza, null),
                                        "Zapomnij, szelmo.", 
                                            new DialogLine("Jak chcesz, nie wiesz, co tracisz.", _sasza, null)
                                        )
                                    ),
                            "Zapomnij, szelmo.", 
                                new DialogLine("Jak chcesz, nie wiesz, co tracisz.", _sasza, null))
                        )
                    )
                )
            );

            //Tamara
            q.AddDialogSequence("Tamara", new DialogSequence(
                new DialogLine("Elektrij, szybko, trzeba włączyć sekcję zasilania w inkubatorach!", _tamara, 
                    new DialogLine("Spokojnie, słyszałem już o problemach w szpitalu. Gdzie znajdę sekcję zasilającą?", _elektrij,
                        new DialogLine("Jest na końcu prawego korytarza, musisz minąć wszystkie sale szpitalne.", _tamara,
                            new DialogLine("Dzięki, śpieszę to naprawić.", _elektrij, null)
                            )
                        )
                    )
                )
            );

            //Tatiana
            q.AddDialogSequence("Tatiana", new DialogSequence(new DialogLine("Nie mam teraz czasu, muszę pomóc mężowi zarządzać farmą. Wybacz, Elektrij.", _tatiana, null)));

            return q;
        }

        private Quest GetQuest2(Quest nextQuest)
        {
            DialogLine startLine = new DialogLine("Quest nr 2 poczatek", _elektrij, null);
            DialogLine endLine = new DialogLine("Quest nr 2 koniec", _elektrij, null);

            DialogSequence beginningSequence = new DialogSequence(startLine);
            DialogSequence endingSequence = new DialogSequence(endLine);

            return new Quest(beginningSequence, endingSequence, nextQuest);
        }
        private Quest GetQuest3(Quest nextQuest)
        {
            DialogLine startLine = new DialogLine("Quest nr 3 poczatek", _elektrij, null);
            DialogLine endLine = new DialogLine("Quest nr 3 koniec", _elektrij, null);

            DialogSequence beginningSequence = new DialogSequence(startLine);
            DialogSequence endingSequence = new DialogSequence(endLine);

            return new Quest(beginningSequence, endingSequence, nextQuest);
        }

        public Quest GetQuests()
        {
            return GetQuest1(GetQuest2(GetQuest3(null)));
        }

    }
}
