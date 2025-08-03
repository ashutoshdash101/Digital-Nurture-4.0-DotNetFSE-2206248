import React from 'react';
import './App.css';

function App() {
  const office = {
    name: "DBS",
    rent: 50000,
    address: "Chennai",
    image: "/360_F_384552930_zPoe9zgmCF7qgt8fqSedcyJ6C6Ye3dFs.jpg"  // 🔥 Relative to public/
  };

  const rentStyle = {
    color: office.rent < 60000 ? 'red' : 'green',
    fontWeight: 'bold'
  };

  return (
    <div className="container">
      <h1>Office Space , at Affordable Range</h1>
      <img src={office.image} alt="Office" className="office-img" />

      <p><strong>Name:</strong> {office.name}</p>
      <p style={rentStyle}><strong>Rent: Rs. {office.rent}</strong></p>
      <p><strong>Address:</strong> {office.address}</p>
    </div>
  );
}

export default App;
