o	How did you approach the problem?

    Feature 1 of Snakes and Ladders focused mainly on the token movement, with the first task focusing on the token movement across the board. Therefore, using TDD a new game instance was initiliased and return token at position 1, (first as harcoded value) and then further evolved to meet the requirements of the movement. 
    Next winning the game was complete by insuring the token reached a value above 100. And then a following test to guard against Token passing the 100 limit. 
    A dice was seperated in it's own test class and class. as it is an independent entity. a very simple test to ensure the value will be within the range, following the implementation of returning a random number between 1 & 6
    
    
o	How did you make key design decisions and what alternatives did you consider?

    Whether a dice needs to be within the game, but I have decided it shares no common functionality with the game and therefore should be seperated. Created an interface for it as a dice can be used in other board games and have other functionality/ shapes.
    However I decided to keep the token within the the game, as it shares the location and movement on the board.
    
    
o	How do you envision your solution evolving in the future?

    the way I have built the game, is that each player will instantiate a new game, and roll the dice to further move the token to win the game.
