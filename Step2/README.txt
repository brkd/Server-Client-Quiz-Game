This is a server-client program which was written in C#. In the program, 2 clients try to connect to a server which listens to a port,

which is taken as an input through the server GUI. Server distinguishes clients using their names which are also taken as inputs through the

client GUI. When a client tries to use the name of an existing client, it will be rejected and will be asked to provide another name. When all the

clients are ready, the server will start the quiz game. Server starts the game when there are exactly 2 clients connected. The user which has the

alphabetically smaller name goes first. The server lets the users know when they are to ask questions using a string sent as a byte array to the

clients. The question and the answers are all visible on the server feed. Question and answer are sent in the same string, therefore some identifications

are needed. To solve this issue, clients should enter the question with a question mark at the and and the answer with a dot at the end. When the server

receives the message from the client, it starts from the beginning and reads until it encounters a question mark,this part is stored in a seperate string

called question, rest of the string until a dot is seen is also stored in another string named answer. Question is sent to the second user and he/she will

see only the question and will try to answer the question, again with a dot at the end, sent by the first user. Answers are compared by the server and both

of the clients are informed about the result, whether the other client guessed the answer successfully or not. Question, answer and the result will all be

shown in the server screen as well. The clients will take turns using a boolean which is a static global variable in the server program. When a client

finishes asking a question, server changes the value of the boolean so that the other player can ask after answering the question. The game continues until

a client leaves or the server shuts down. When a client shuts down, the server is informed and it immediately stops execution of the game, making it unable

for the other player to continue by informing him/her. When the server shuts down before all the clients leave, it first shuts down the connection and informs

the players by sending a message. 