namespace Saber.Node;

public class ArrayStructTypeNameNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteArrayStructTypeName(range);
        return true;
    }
}