using Memphis;
using Memphis.Conditions;
using Memphis.Actions;

namespace MEMPHIS_SHARP
{
    public partial class MainForm : Form, IEngineObserver
    {
        public void CreateDefaultTransforms()
        {
            mEngine.ApplyTransformsToToken(null);

            //  Upcase all words
            //mEngine.AddTransform(
                //new ConditionAlways(),
                //new ActionChangeCase(mEngine, true, false, true)
                //);

            //  Discard numeric tokens

            //  lowcase extensions

            //  upcase several strings

            //  add dot after various tokens
        }
    }
}
