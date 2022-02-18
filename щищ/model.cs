using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace щищ
{
    [Serializable]
    public class Value
    {
        string name;

        public Value() { }

        public Value(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => this.name = value; }

        public override string ToString()
        {
            return name;
        }
    }

    [Serializable]
    public class Domain
    {
        string name;
        List<Value> values;

        public Domain() { }

        public Domain(string name, List<Value> values)
        {
            this.name = name;
            this.values = values;
        }

        public string Name { get => name; set => name = value; }
        public List<Value> Values { get => values; set => values = value; }

        public override string ToString()
        {
            return values.Select(x => $"{x.Name}")
                .Aggregate((x, y) => $"{x} // {y}");
        }
    }

    [Serializable]
    public enum V_Type
    {
        In, Out, In_Out 
    }

    [Serializable]
    public class Variable
    {
        string name;
        Domain domain;
        V_Type vType;

        public Variable() { }

        public Variable(string name, Domain domain, V_Type vType)
        {
            this.Name = name;
            this.Domain = domain;
            this.VType = vType;
        }

        public string Name { get => name; set => name = value; }
        public Domain Domain { get => domain; set => domain = value; }
        public string Question { get => name + "?";}
        public V_Type VType { get => vType; set => vType = value; }

        public string Type()
        {
            switch (vType)
            {
                case V_Type.In:
                    return "Запрашиваемая";
                case V_Type.Out:
                    return "Выводимая";
                case V_Type.In_Out:
                    return "Запрашиваемо-выводимая";
            }
            return "";
        }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class Fact
    {
        Variable variable;
        Value value;

        public Fact() { }
        public Fact(Variable variable, Value value)
        {
            this.variable = variable;
            this.value = value;
        }

        public Variable Variable { get => variable; set => variable = value; }
        public Value Value { get => value; set => this.value = value; }

        public override string ToString()
        {
            return $"{variable.Name} = {Value.Name}";
        }
    }

    [Serializable]
    public class Rule
    {
        string name;
        List<Fact> conditions;
        List<Fact> conclusions;
        string reason;

        public Rule() { }

        public Rule(string name, List<Fact> conditions, List<Fact> conclusions, string reason)
        {
            this.name = name;
            this.conditions = conditions;
            this.conclusions = conclusions;
            this.reason = reason;
        }

        public string Name { get => name; set => name = value; }
        public List<Fact> Conditions { get => conditions; set => conditions = value; }
        public List<Fact> Conclusions { get => conclusions; set => conclusions = value; }
        public string Reason { get => reason; set => reason = value; }

        public override string ToString()
        {
            string cond = conditions.Select(x => $"{x}")
                .Aggregate((x, y) => $"{x} И {y}");
            string conc = conclusions.Select(x => $"{x}")
                .Aggregate((x, y) => $"{x} И {y}"); ;

            return $"ЕСЛИ {cond} \nТО {conc}";
        }
    }

    [Serializable]
    public class KBase
    {
        List<Rule> rules = new List<Rule>();
        List<Variable> variables = new List<Variable>();
        List<Domain> domains = new List<Domain>();
        Variable goal;

        public KBase() { }

        public KBase(List<Rule> rules, List<Variable> variables, List<Domain> domains, Variable goal)
        {
            this.rules = rules;
            this.variables = variables;
            this.domains = domains;
            this.goal = goal;
        }

        public void Update(List<Rule> rules, List<Variable> variables, List<Domain> domains, Variable goal)
        {
            this.rules = rules;
            this.variables = variables;
            this.domains = domains;
            this.goal = goal;
        }

        public List<Rule> Rules { get => rules; set => rules = value; }
        public List<Variable> Variables { get => variables; set => variables = value; }
        public List<Domain> Domains { get => domains; set => domains = value; }
        public Variable Goal { get => goal; set => goal = value; }
    }

    public class TRule
    {
        public Rule Rule { get; set; }
        public int Level { get; set; }
        public Fact Goal { get; set; }

        public TRule(Rule rule, int level, Fact goal)
        {
            Rule = rule;
            Level = level;
            Goal = goal;
        }

        public override string ToString()
        {
            return Rule is null ? $"Цель: {Goal} (запрошено у пользователя)" : $"Цель: {Goal}\n{Rule}";
        }
    }

    public class WorkMemory
    {
        KBase kBase;
        List<TRule> triggeredRules;
        //List<Rule> untriggeredRules;

        public WorkMemory() { }

        public WorkMemory(KBase kBase)
        {
            this.kBase = kBase;
            triggeredRules = new List<TRule>();
            //Rule r = new Rule("heh", null, null, "lol");
            //triggeredRules.Add(new TRule(r, 0));
            //triggeredRules.Add(new TRule(r, 0));
            //triggeredRules.Add(new TRule(r, 1));
            //triggeredRules.Add(new TRule(r, 0));
            //triggeredRules.Add(new TRule(r, 1));
            //triggeredRules.Add(new TRule(r, 1));
            //triggeredRules.Add(new TRule(r, 2));
            //triggeredRules.Add(new TRule(r, 2));
            //triggeredRules.Add(new TRule(r, 1));
            //triggeredRules.Add(new TRule(r, 2));
            //triggeredRules.Add(new TRule(r, 3));
            //triggeredRules.Add(new TRule(r, 0));
        }

        public KBase KBase { get => kBase; set => kBase = value; }
        public List<TRule> TriggeredRules { get => triggeredRules; set => triggeredRules = value; }
        //public List<Rule> UntriggeredRules { get => untriggeredRules; set => untriggeredRules = value; }
        public Dictionary<string, Fact> Facts { get; set; } = new Dictionary<string, Fact>();
    }

    public class MLV
    {
        WorkMemory workMemory;

        public MLV() { }

        public MLV(WorkMemory workMemory)
        {
            this.workMemory = workMemory;
        }

        public WorkMemory WorkMemory { get => workMemory; set => workMemory = value; }

        private static Fact AskVariable(Variable variable)
        {
            var av = new AskVariable(variable);

            av.ShowDialog();

            return av.Fact;
        }

        private static bool CheckFacts(Fact a, Fact b)
        {
            return a.Value.Name == b.Value.Name;
        }

        private Fact FindVarValue(Variable variable, int level)
        {
            if (variable.VType == V_Type.In)
            {
                Fact f = AskVariable(variable);

                if (workMemory.Facts.ContainsKey(variable.Name))
                    workMemory.Facts[variable.Name] = f;
                else
                    workMemory.Facts.Add(variable.Name, f);

                workMemory.TriggeredRules.Add(new TRule(null, level, workMemory.Facts[variable.Name]));

                return f;
            }

            List<Rule> rules = workMemory.KBase.Rules;

            var r = rules.Where(x => x.Conclusions.Where(y => y.Variable.Name == variable.Name).ToList().Count > 0).ToList();

            for (int i = 0; i < r.Count; i++)
            {
                bool worked = true;

                for (int j = 0; j < r[i].Conditions.Count; j++)
                {
                    Fact f = new Fact();

                    if (workMemory.Facts.ContainsKey(r[i].Conditions[j].Variable.Name))
                        f = workMemory.Facts[r[i].Conditions[j].Variable.Name];
                    else
                        f = FindVarValue(r[i].Conditions[j].Variable, level + 1);

                    if (!CheckFacts(f, r[i].Conditions[j]))
                    {
                        worked = false;
                        break;
                    }
                }

                if (worked)
                {
                    foreach (Fact f in r[i].Conclusions)
                    {
                        if (workMemory.Facts.ContainsKey(f.Variable.Name))
                            workMemory.Facts[f.Variable.Name] = f;
                        else
                            workMemory.Facts.Add(f.Variable.Name, f);
                    }

                    workMemory.TriggeredRules.Add(new TRule(r[i], level, workMemory.Facts[variable.Name]));

                    return workMemory.Facts[variable.Name];
                }
            }

            if (variable.VType == V_Type.In_Out)
            {
                Fact f = AskVariable(variable);

                if (workMemory.Facts.ContainsKey(variable.Name))
                    workMemory.Facts[variable.Name] = f;
                else
                    workMemory.Facts.Add(variable.Name, f);

                workMemory.TriggeredRules.Add(new TRule(null, level, workMemory.Facts[variable.Name]));

                return f;
            }

            return new Fact(variable, new Value("Не удалось найти ответ"));
        }

        public Value GetAnswer()
        {
            Variable goal = workMemory.KBase.Goal;

            return FindVarValue(goal, 0).Value;

            //return new Value("нинаю");
        }
    }
}
