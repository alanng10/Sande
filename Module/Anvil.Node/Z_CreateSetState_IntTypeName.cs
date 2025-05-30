namespace Saber.Node;

public class IntTypeNameCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        IntTypeName node;
        node = (IntTypeName)arg.Node;
        node.Kind = k.FieldInt;
        return true;
    }
}