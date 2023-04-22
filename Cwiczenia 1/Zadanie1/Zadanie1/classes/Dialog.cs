using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.classes
{
    class DialogParser
    {
        Hero _hero;

        public DialogParser(Hero hero)
        {
            this._hero = hero;
        }

        public string ParseDialog(IDialogPart iDialogPart)
        {
            return String.Format(iDialogPart.getDialog(), _hero.name);
        }
    }

    class NpcDialogPart : IDialogPart
    {
        String _dialog;
        List<HeroDialogPart> _heroOptions;

        public NpcDialogPart(String dialog)
        {
            this._dialog = dialog;
            this._heroOptions = new List<HeroDialogPart>();
        }

        public void AddHeroOption(HeroDialogPart heroOption)
        {
            this._heroOptions.Add(heroOption);
        }

        public String getDialog()
        {
            return _dialog;
        }

        public List<HeroDialogPart> getHeroOptions()
        {
            return _heroOptions;
        }
    }

    class HeroDialogPart : IDialogPart
    {
        String _dialog;
        NpcDialogPart _npcAnswer;

        public HeroDialogPart(String dialog)
        {
            this._dialog = dialog;
        }

        public void AddNpcAnswer(NpcDialogPart npcAnswer)
        {
            this._npcAnswer = npcAnswer;
        }

        public NpcDialogPart GetNpcAnswer()
        {
            return _npcAnswer;
        }

        public String getDialog()
        {
            return _dialog;
        }
    }

    interface IDialogPart
    {
        String getDialog();
    }
}
