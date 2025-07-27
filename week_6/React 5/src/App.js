import React from 'react';
import CohortDetails from './CohortDetails'; 

function App() {
    return (
        <div style={{ textAlign: 'center', padding: '20px' }}>
            <h1>Cohorts Details</h1>
            <div style={{ display: 'flex', justifyContent: 'center', flexWrap: 'wrap' }}>
                <CohortDetails
                    cohortName="INTADMF10 - .NET FSD"
                    startedOn="22-Feb-2022"
                    currentStatus="Scheduled"
                    coach="Rahul Roy"
                    trainer="Ashutosh Dash"
                />
                <CohortDetails
                    cohortName="ADM21JF014 - Java FSD"
                    startedOn="10-Sep-2021"
                    currentStatus="Ongoing"
                    coach="Harish Mallick"
                    trainer="Kumar Sanu"
                />
                <CohortDetails
                    cohortName="CDBJF21025 - Java FSD"
                    startedOn="24-Dec-2021"
                    currentStatus="Ongoing"
                    coach="Sneha Rajput"
                    trainer="Ranbir Malhotra"
                />
            </div>
        </div>
    );
}

export default App;