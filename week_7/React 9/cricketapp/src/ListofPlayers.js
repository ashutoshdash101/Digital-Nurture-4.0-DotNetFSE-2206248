import React from 'react';

const ListofPlayers = () => {
    const players = [
        { name: 'Mr. Jack', score: 50 },
        { name: 'Mr. Michael', score: 70 },
        { name: 'Mr. John', score: 40 },
        { name: 'Mr. Ann', score: 61 },
        { name: 'Mr. Elizabeth', score: 61 },
        { name: 'Mr. Sachin', score: 95 },
        { name: 'Mr. Dhoni', score: 100 },
        { name: 'Mr. Rahul', score: 84 },
        { name: 'Mr. Jadeja', score: 64 },
        { name: 'Mr. Rana', score: 75 },
        { name: 'Mr. Rohit', score: 80 },
    ];

    const lowScorers = players.filter(player => player.score < 70);

    return (
        <div>
            <h2>List of Players</h2>
            <ul>
                {players.map((player, index) => (
                    <li key={index}>{player.name} {player.score}</li>
                ))}
            </ul>

            <h2>List of Players having Scores less than 70</h2>
            <ul>
                {lowScorers.map((player, index) => (
                    <li key={index}>{player.name} {player.score}</li>
                ))}
            </ul>
        </div>
    );
};

export default ListofPlayers;
