using ReizTechAssignment;

bool exitLoop = true;

do
{
    Writer.Greet();

    int input = Writer.GetInput();
    switch(input)
    {
        case 0:
            exitLoop = false;
            break;
        case 1:
            var clock = new ExecuteFirstPart();
            ExecuteFirstPart.Execute();
            break;
        case 2:
            var tree = new ExecuteSecondPart();
            ExecuteSecondPart.Execute();
            break;
        default:
            Writer.ShowErrorMessage();
            break;
    }

}while (exitLoop);