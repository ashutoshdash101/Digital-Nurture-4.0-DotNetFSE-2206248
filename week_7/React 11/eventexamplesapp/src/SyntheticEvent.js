import React from 'react';

function SyntheticEvent() {
  
  const handlePress = (e) => {
    
    console.log(e);
    alert('I was clicked'); // [cite: 23]
  };

  return (
    <div>
      <h2>Synthetic Event Example</h2>
      {/* The onClick event in React is a synthetic event [cite: 23] */}
      <button onClick={handlePress}>OnPress</button>
    </div>
  );
}

export default SyntheticEvent;