

namespace RespirationsComment
{
    class PositionalRemEffect : Respirations
    {
        static int[,] ResultsTable = new int[2, 2];

        PositionalRemEffect()
        {
            initializeResultsTable();



        }

        private static void initializeResultsTable()
        {
            //                 Positional Effect        REM Effect
            ResultsTable[(int)Effect.Effect_True, (int)Effect.Effect_True] = 0;
            ResultsTable[(int)Effect.Effect_True, (int)Effect.Effect_False] = 1;

            ResultsTable[(int)Effect.Effect_False, (int)Effect.Effect_True] = 2;
            ResultsTable[(int)Effect.Effect_False, (int)Effect.Effect_False] = 3;
        }


    }
}
