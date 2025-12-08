// Goal.cs
using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Retorna os pontos ganhos quando o evento é registrado.
    // Implementação específica em cada classe derivada.
    public abstract int RecordEvent();

    // Retorna true se o objetivo estiver completo (se aplicável).
    public abstract bool IsComplete();

    // Representação legível para a lista de metas.
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }

    // Representação usada para salvar/recuperar do arquivo
    public virtual string GetStringRepresentation()
    {
        // Formato genérico (poderá ser sobrescrito)
        return $"{GetType().Name}:{_name}|{_description}|{_points}";
    }

    public string GetName()
    {
        return _name;
    }
}
