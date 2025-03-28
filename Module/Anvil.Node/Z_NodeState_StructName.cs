namespace Saber.Node;

public class StructNameNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteStructName(range);
        return true;
    }
}