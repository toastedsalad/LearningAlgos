namespace LearningAlgos;

public class BoundedRobot{
    public bool IsRobotBounded(string instructions){
        // The robot has to end up in the same place.
        // What if tranlate all the instructions and then check if the first
        // and last place are identical
        
        int x = 0;
        int y = 0;
        char currentlyFacing = 'N';
        
        for(var i = 0; i < instructions.Length; i++){
            switch (instructions[i]){
                case 'G':
                    if(currentlyFacing == 'N'){y++;}
                    else if (currentlyFacing == 'S'){y--;}
                    else if(currentlyFacing == 'E'){x++;}
                    else if(currentlyFacing == 'W'){x--;}
                    break;
                case 'L':
                    if(currentlyFacing == 'N'){currentlyFacing = 'W';}
                    else if(currentlyFacing == 'W'){currentlyFacing = 'S';} 
                    else if(currentlyFacing == 'S'){currentlyFacing = 'E';}
                    else if(currentlyFacing == 'E'){currentlyFacing = 'N';}
                    break;
                case 'R':
                    if(currentlyFacing == 'N'){currentlyFacing = 'E';}
                    else if(currentlyFacing == 'E'){currentlyFacing = 'S';} 
                    else if(currentlyFacing == 'S'){currentlyFacing = 'W';}
                    else if(currentlyFacing == 'W'){currentlyFacing = 'N';}
                    break;
            }
        }

        if((x == 0 && y == 0) || currentlyFacing != 'N'){
            return true;
        }

        return false;
    }
}
