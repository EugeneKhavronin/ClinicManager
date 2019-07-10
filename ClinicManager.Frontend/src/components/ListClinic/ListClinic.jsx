import React from 'react';
import './ListClinic.css';
// eslint-disable-next-line import/no-named-as-default
import ListItemClinic from '../ListItemClinic/ListItemClinic';


const ListClinic = ({ todos, onDeleted, onMore }) => {
  const elements = todos.map(item => {
    const { clinicGuid, ...itemProps } = item;
    return (
      <div key={clinicGuid}>
        <ListItemClinic
          {...itemProps}
          onDeleted={() => onDeleted(clinicGuid)}
          onMore={() => onMore(clinicGuid)}
        />
      </div>
    );
  });
  return <div className="list-group todo-list">{elements}</div>;
};

export default ListClinic;
