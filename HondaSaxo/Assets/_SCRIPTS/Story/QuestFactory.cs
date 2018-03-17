using UnityEngine;

namespace Assets._SCRIPTS.Story
{
    public class QuestFactory
    {
        private readonly Character _elektrij;
        private readonly Character _aleksiej;
        private readonly Character _dimitrij;
        private readonly Character _elena;
        private readonly Character _igor;
        private readonly Character _iwan;
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
            _dimitrij = new Character("Dimitrij", false);
            _elena = new Character("Elena", false);
            _igor = new Character("Igor", false);
            _iwan = new Character("Iwan", false);
            _natasza = new Character("Natasza", false);
            _nikolai = new Character("Nikolai", false);
            _nina = new Character("Nina", false);
            _sasza = new Character("Sasza", false);
            _sergiej = new Character("Sergiej", false);
            _tamara = new Character("Tamara", false);
            _tatiana = new Character("Tatiana", false);
            _wania = new Character("Wania", false);
        }

        private Quest GetQuest1(Quest nextQuest)
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
