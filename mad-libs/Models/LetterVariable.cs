namespace Madlibs.Models
{
    public class LetterVariable
    {
        private string _name;
        private string _anotherName;
        private string _animal;
        private string _exclamation;
        private string _verb;
        private string _noun;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public string GetAnotherName()
        {
            return _anotherName;
        }

        public void SetAnotherName(string newAnotherName)
        {
            _anotherName = newAnotherName;
        }

        public string GetAnimal()
        {
            return _animal;
        }

        public void SetAnimal(string newAnimal)
        {
            _animal = newAnimal;
        }

        public string GetExclamation()
        {
            return _exclamation;
        }

        public void SetExclamation(string newExclamation)
        {
            _exclamation = newExclamation;
        }

        public string GetVerb()
        {
            return _verb;
        }

        public void SetVerb(string newVerb)
        {
            _verb = newVerb;
        }

        public string GetNoun()
        {
            return _noun;
        }

        public void SetNoun(string newNoun)
        {
            _noun = newNoun;
        }



    }
}