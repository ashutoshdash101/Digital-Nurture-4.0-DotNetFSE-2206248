import React, { useState } from 'react';
import './App.css';
function App() {
  const [count, setCount] = useState(0);
  const [amount, setAmount] = useState('');
  const [currency, setCurrency] = useState('');
  const [message, setMessage] = useState('');
const increment = () => {
    setCount(prev => prev + 1);
    sayHello();
  };
const decrement = () => {
    setCount(prev => prev - 1);
  };
const sayHello = () => {
    alert('Hello! Counter incremented');
  };
 const sayWelcome = (msg) => {
    alert(msg);
  };
const handlePress = (e) => {
    alert("I was clicked");
  };
 const handleSubmit = (e) => {
    e.preventDefault();
    const result = (parseFloat(amount) / 90).toFixed(2);
     alert("Converting to euro amount is " + result);
     setCurrency("Euro")
  };
 return (
    <div className="App">
      <h2>Counter: {count}</h2>
      <button onClick={increment}>Increment</button>{' '}
      <button onClick={decrement}>Decrement</button>{' '}
      <button onClick={() => sayWelcome("Welcome")}>Say Welcome</button>{' '}
      <button onClick={handlePress}>Click on me</button>

      <h2 style={{ color: "green" }}>Currency Convertor!!!</h2>
      <form onSubmit={handleSubmit}>
        <label>Amount:</label><br />
        <input
          type="number"
          value={amount}
          onChange={(e) => setAmount(e.target.value)}
        /><br />
        <label>Currency:</label><br />
        <input type="text" value={currency} readOnly /><br /><br />
        <button type="submit">Submit</button>
      </form>
    </div>
  );
}
export default App;
