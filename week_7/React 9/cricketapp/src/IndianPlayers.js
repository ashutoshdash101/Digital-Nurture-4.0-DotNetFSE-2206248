import React from 'react';

const IndianPlayers = () => {
    const players = ['Sachin1', 'Dhoni2', 'Virat3', 'Rohit4', 'Yuvraj5', 'Raina6'];
    const [first, second, third, fourth, fifth, sixth] = players;

    const T20players = [
        'Mr. First Player',
        'Mr. Second Player',
        'Mr. Third Player'
    ];

    const RanjiPlayers = [
        'Mr. Fourth Player',
        'Mr. Fifth Player',
        'Mr. Sixth Player'
    ];

    const merged = [...T20players, ...RanjiPlayers];

    return (
        <div>
            <h2>Odd Players</h2>
            <ul>
                <li>First : {first}</li>
                <li>Third : {third}</li>
                <li>Fifth : {fifth}</li>
            </ul>

            <h2>Even Players</h2>
            <ul>
                <li>Second : {second}</li>
                <li>Fourth : {fourth}</li>
                <li>Sixth : {sixth}</li>
            </ul>

            <h2>List of Indian Players Merged:</h2>
            <ul>
                {merged.map((player, i) => (
                    <li key={i}>{player}</li>
                ))}
            </ul>
        </div>
    );
};

export default IndianPlayers;
