namespace Assets._SCRIPTS.Story
{
    public class QuestFactory
    {
        private Character elektrij = new Character(true);
        private Character innaMorda = new Character(false);
        public QuestFactory()
        {

        }

        private Quest GetQuest1(Quest nextQuest)
        {
            DialogLine startLine =
                new DialogLine("- Czesc Dimitrii", elektrij,
                    new DialogLine("- Spierdalaj", innaMorda,
                        new DialogChoice("Co chcesz zrobic Dimitriemu", elektrij,
                            "Zajebac lepe", new DialogLine("* Lepa odjebala Dimitriiowi glowe! *", innaMorda, null),
                            "Zasadzic luja z calej epy", new DialogLine("- O zesz Ty kurwa!", innaMorda, null),
                            "Wyjebac z dyni", new DialogLine("* Dimitrii implodowal *", innaMorda, null)
                        )
                    )
                );

            DialogLine endLine =
                new DialogLine("No i dobrze, ze z dech", elektrij,
                    new DialogLine("No raczej kurwa nie inaczej", innaMorda,
                        new DialogLine("No i kurwa pierwszorzednie mordo, elo", elektrij, null)));

            DialogSequence beginningSequence = new DialogSequence(startLine);
            DialogSequence endingSequence = new DialogSequence(endLine);

            return new Quest(beginningSequence, endingSequence, nextQuest);
        }
        private Quest GetQuest2(Quest nextQuest)
        {
            DialogLine startLine = new DialogLine("Quest nr 2 poczatek", elektrij, null);
            DialogLine endLine = new DialogLine("Quest nr 2 koniec", elektrij, null);

            DialogSequence beginningSequence = new DialogSequence(startLine);
            DialogSequence endingSequence = new DialogSequence(endLine);

            return new Quest(beginningSequence, endingSequence, nextQuest);
        }
        private Quest GetQuest3(Quest nextQuest)
        {
            DialogLine startLine = new DialogLine("Quest nr 3 poczatek", elektrij, null);
            DialogLine endLine = new DialogLine("Quest nr 3 koniec", elektrij, null);

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
