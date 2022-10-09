Unity Editor Version is 2020.3.16f1

# QodeUnlocked - Quantum Game Jam 2022 Version (Previous)
* ### _[Jam submission page](https://itch.io/jam/quantum-game-jam-2022/rate/1707788)_

* ### _[Jam version gameplay Video](https://drive.google.com/file/d/17gOITk_pUpgzWqfTfTRoai0zxWkfs8Je/view?usp=drivesdk)_

### How to Install
1. setup python2.7 environment for Unity [here](https://docs.unity3d.com/Packages/com.unity.scripting.python@2.0/manual/PythonScriptEditor.html)
2. download pip and download qiskit library


# QodeUnlocked - Quantum Games Hackathon 2022 Version
#### _<div align="center">2nd winner of Quantum Games Hackathon</div> <div align="center">https://www.qaif.org/contests/quantum-games-hackathon</div>_ 

* ### _[Hackathon version gameplay Video](https://drive.google.com/file/d/1oTSDONsytLBLJm4wGzcNyyCYKggKdeO6/view?usp=sharing)_

### Which commits belong to Quantum game jam version / which ones Quantum game hackathon version?
Up to this commit (including this commit), it belongs to the game jam version:
[2d9f7a8d4602d0f60077d3a6be734dd8d091f416](https://github.com/selindoga/Quantum-Game-Jam-2022/commit/2d9f7a8d4602d0f60077d3a6be734dd8d091f416)
And all the commits after that belongs to Quantum Games Hackathon.

### An insight to our game QodeUnlocked
The game idea originated from trying to connect quantum physics and computing ideas with the theme of the recent Quantum Game Jam hosted by Ijpiis- ‘Patterns’. Thinking about patterns, the pattern locks used to protect our phones came to mind. This lead to the idea of creating a game based on password protection but rather than swiping a finger onscreen to enter the right pattern or tapping the right number code, QodeUnlocked brings with it a quantum twist which is to enter the right combination of quantum gates to take the given initial quantum state to set final quantum state.

The game targets beginners at the starting point in the path of exploring and learning quantum computing. The game begins by introducing basic quantum ideas such as superposition and eventually aims to incorporate advance topics in the field to help players develop a quantum intuition gradually. This makes the game educational and beginner-friendly. Currently, the game consists of three basic levels and we aim to add more levels to the game eventually to make it a full-fledged game in future. 

In the previous quantum game jam, we started with the above stated game idea and due to a mistake on our half, we had to work on realizing this idea in a very short time due to which, the development part of the game was scarce and had a lot to be worked on (this can be confirmed from the git-repo attached in the submission). We only had one game level with only took inputs and declared if the combination of quantum games was right or wrong. This time, we worked on developing a project which strongly holds the essence of a proper game with catchy visual frames, sound effects and effective guides to provide the player with a good idea of how the game is supposed to be played. All the frames used in the game have been designed from scratch and then gathered all the assets together into Unity and programmed all during the hackathon. The sound effects are afresh added to the game and it is made sure that all sound effects used in the game are royalty-free and freely available for commercial and non-commercial use.


_Name of Game: QodeUnlocked_

_Team name: Quantum Potatoes_

_Team members: Surabhi Srivastava - Quantum Physicist, Selin Doğa Orhan - Developer_


• Game developed using Unity

• Visual designs and templates created using Canva: [Canva project](https://www.canva.com/design/DAFNWsNGKys/BUAtXKJDIC1oohEYsusFzg/edit?utm_content=DAFNWsNGKys&&utm_campaign=designshare&&utm_medium=link2&&utm_source=sharebutton)

• Sound effects taken from Pixabay

__Briefing of topics in Quantum Physics and Computation used in the game is listed below for reference, if needed.__

__Qubits:__ Just like bits are the fundamental tool for storing information, quantum information is stored in qubits (quantum bits). The crucial difference is that a classical bit can store binary information in form of either 0 or 1. Qubits can be in a superposed state of 0 and 1 with certain probabilities.

__Single Qubit gates:__ These are the quantum gates that operate on single qubits to transform the state of the qubit according to requirement. The single qubit gates used in the game are: Identity gate, Pauli X, Y and Z gates, Hadamard gate, S gate.

__Multi Qubit gates:__ These are the quantum gates that operate on two or more qubits to transform qubits state according to requirement. The multiple qubit gate used in the game is the controlled quantum gate represented as CA(a,b) where A is the gate to be applied to target qubit ‘a’ if the control qubit ‘b’ is in state |1>

__Tensor Product:__ Tensor products are used to represent multi-state systems where the qubits belong to different Hilbert spaces. They are represented by ⊗ symbol.

__Superposition:__ As mentioned earlier, qubits can be in a superposed state of 0 and 1 with certain probabilities. Quantum computing uses this property as an advantage over classical computers.

__Entanglement:__ In a multistate system, when qubits are said to be entangled, measurement of one qubit effects the state of the other qubit and this is a very powerful tool used to increase efficiency of computation using quantum properties. One example is that the hurdle of ‘no cloning theorem’ is overridden with the help of entanglement to obtain the quantum state of one qubit into another qubit called the ancilla qubit without losing information.

_Additional Note:_ We have not included measurements of quantum states after operation of quantum gates. The game focusses on understanding operations of quantum gates on qubits and the mathematical details of it.
