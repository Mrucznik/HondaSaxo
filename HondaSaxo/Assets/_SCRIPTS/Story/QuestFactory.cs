using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._SCRIPTS.Story
{
    public class QuestFactory
    {
        private Quest GetQuest1(Quest nextQuest)
        {
            DialogLine startLine =
                new DialogLine("Czesc Dimitrii",
                    new DialogLine("Spierdalaj",
                        new DialogChoice("Co chcesz zrobic Dimitriemu",
                            "Zajebac lepe", new DialogLine("* Lepa odjebala Dimitriiowi glowe! *", null),
                            "Zasadzic luja z calej epy", new DialogLine("O zesz Ty kurwa!", null),
                            "Wyjebac z dyni", new DialogLine("* Dimitrii implodowal *", null)
                        )
                    )
                );

            DialogLine endLine =
                new DialogLine("No i dobrze, ze z dech",
                    new DialogLine("No raczej kurwa nie inaczej",
                        new DialogLine("No i kurwa pierwszorzednie mordo, elo", null)));

            DialogSequence beginningSequence = new DialogSequence(startLine);
            DialogSequence endingSequence = new DialogSequence(endLine);

            return new Quest(beginningSequence, endingSequence, nextQuest);
        }
        private Quest GetQuest2(Quest nextQuest)
        {
            DialogLine startLine = new DialogLine("Quest nr 2 poczatek", null);
            DialogLine endLine = new DialogLine("Quest nr 2 koniec", null);

            DialogSequence beginningSequence = new DialogSequence(startLine);
            DialogSequence endingSequence = new DialogSequence(endLine);

            return new Quest(beginningSequence, endingSequence, nextQuest);
        }
        private Quest GetQuest3(Quest nextQuest)
        {
            DialogLine startLine = new DialogLine("Quest nr 3 poczatek", null);
            DialogLine endLine = new DialogLine("Quest nr 3 koniec", null);

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
