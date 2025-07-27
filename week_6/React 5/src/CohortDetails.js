import React from 'react';
import styles from './CohortDetails.module.css'; 

const CohortDetails = ({ cohortName, startedOn, currentStatus, coach, trainer }) => {
   
    const cohortNameStyle = {
        color: currentStatus === 'Ongoing' ? 'green' : 'blue'
    };

    return (
        <div className={styles.box}> 
            <h3 style={cohortNameStyle}>{cohortName}</h3>
            <dl>
                <dt>Started On</dt>
                <dd>{startedOn}</dd>

                <dt>Current Status</dt>
                <dd>{currentStatus}</dd>

                <dt>Coach</dt>
                <dd>{coach}</dd>

                <dt>Trainer</dt>
                <dd>{trainer}</dd>
            </dl>
        </div>
    );
};

export default CohortDetails;