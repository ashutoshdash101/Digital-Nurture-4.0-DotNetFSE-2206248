import React, { Component } from 'react';

class CurrencyConvertor extends Component {
  constructor(props) {
    super(props);
    this.state = {
      rupees: 1,
      euros: 0,
    };
    
    this.exchangeRate = 0.011; // 1 INR = 0.011 EUR
  }

  handleRupeeChange = (event) => {
    this.setState({ rupees: event.target.value });
  };

  
  handleSubmit = (event) => {
    event.preventDefault(); 
    const convertedEuros = this.state.rupees * this.exchangeRate;
    this.setState({ euros: convertedEuros.toFixed(2) });
  };

  render() {
    return (
      <div>
        <h2>CurrencyConvertor [cite: 24]</h2>
        <form onSubmit={this.handleSubmit}>
          <div>
            <label>Indian Rupees (INR): </label>
            <input
              type="number"
              value={this.state.rupees}
              onChange={this.handleRupeeChange}
            />
          </div>
          <button type="submit">Convert</button>
        </form>
        <h3>Converted Amount in Euro (€): {this.state.euros}</h3>
      </div>
    );
  }
}

export default CurrencyConvertor;