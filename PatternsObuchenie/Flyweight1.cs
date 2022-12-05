using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatternsObuchenie
{
    internal class Parameters
    {
        public string className; 
        public string text;
    }
    internal abstract class HtmlElement
    {
        public Parameters states;
        public HtmlElement(Parameters parameters)
        {
            this.states = parameters;
        }
        public abstract string ReturnHtmlString(string x); 
    }
    internal class Button:HtmlElement
    {
        public Button(Parameters parameters): base(parameters)
        {
        }
        public override string ReturnHtmlString(string x)
        {
            return $"<button class = {states}></button>";
        }
    }
    internal class FactoryHtmlElement
    {
        private Dictionary<string, HtmlElement> elements = new Dictionary<string, HtmlElement>();
        public FactoryHtmlElement(Parameters parameters)
        {
            elements.Add("button", new Button(parameters));
        }
        public HtmlElement GetElement(string html)
        {
            if (elements.ContainsKey(html))
            {
                return elements[html];
            }
            return null;
        }
    }
}


