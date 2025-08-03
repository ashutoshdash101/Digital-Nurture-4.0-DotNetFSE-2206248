import React from 'react';

function Welcome() {
  
  const sayMessage = (message) => {
    alert(message);
  };

  return (
    <div>
      <h2>Welcome Component</h2>
      <button onClick={() => sayMessage('welcome')}>Say Welcome</button>
    </div>
  );
}

export default Welcome;