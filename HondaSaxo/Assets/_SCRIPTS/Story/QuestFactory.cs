using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._SCRIPTS.Story
{
    public class QuestFactory
    {
        public Quest getQuests()
        {

            //Test quest
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
            
            return new Quest(beginningSequence, endingSequence, null);
        }

    }
}
