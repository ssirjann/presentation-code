using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation
{
    class Program
    {
        static void Main(string [] args)
        {
            var SirjanSharma = new Presenter();
            var presentation = new Presentation
            {
                Presenter = SirjanSharma,
                Title = "Tools..!",
                Slides = new List<Slide>
                {
                    "Resharper",
                    "Resharper: Quick Fixes",
                    "Resharper: Navigation",
                    "Resharper: Quick Fixes",
                    "Resharper: Code Re-formatter",
                    "Resharper: Refactor",
                    "Resharper: Recent Files",
                    "Resharper: Uncovered",
                    "Visual Studio: Shortly Covered",
                    "Visual Studio: Immediate Window",
                    "Visual Studio: Interactive Window",
                    "Visual Studio: SQL Server Object Explorer",
                    "Extended: Multi Edit",
                    "Extended: Macro",
                    "Version Control",
                    "Overkill: Oh-my-zsh for SVN",
                    "Pros and Cons"
                }
            };
            var loop = true;
            while (loop)
            {
                var slide = presentation.NextSlide()?.Title;
                if (slide == null) loop = false;
            }

            var question = "";




            SirjanSharma.Answer(question);
        }
    }
    class AnswerUnknownException : Exception { }
    class Presenter
    {
        public void Answer(string question)
        {
            throw new AnswerUnknownException();
        }
    }

    class Presentation
    {
        private List<Slide> _slides;
        public string Title { get; set; }
        public Presenter Presenter { get; set; }

        public List<Slide> Slides
        {
            set
            {
                _slides = value;
                _index = 0;
            }
        }

        private int _index;

        public Slide NextSlide()
        {
            return _slides.ElementAtOrDefault(_index++);
        }
    }
}