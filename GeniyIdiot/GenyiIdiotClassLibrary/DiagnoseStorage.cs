namespace GeniyIdiotClassLibrary
{
    public static class DiagnosesStorage
    {
        private static List<Diagnose> diagnoses;

        static DiagnosesStorage()
        {
            diagnoses = new List<Diagnose>
            {
                new Diagnose("Идиот"),
                new Diagnose("Кретин"),
                new Diagnose("Дурак"),
                new Diagnose("Нормальный"),
                new Diagnose("Талант"),
                new Diagnose("Гений")
            };
        }
        public static Diagnose GetDiagnoseAssesment(int rightAnswersCount, int questionsCount)
        {
            var correctAnswerPercent = rightAnswersCount * 100 / questionsCount;
            var diagnoses = GetAll();
            if (correctAnswerPercent < 20)
            {
                return diagnoses[0];
            }
            if (correctAnswerPercent < 40)
            {
                return diagnoses[1];
            }
            if (correctAnswerPercent < 60)
            {
                return diagnoses[2];
            }
            if (correctAnswerPercent < 80)
            {
                return diagnoses[3];
            }
            if (correctAnswerPercent < 100)
            {
                return diagnoses[4];
            }
            return diagnoses[5];
        }
        private static List<Diagnose> GetAll()
        {
            return diagnoses;
        }
    }
}
