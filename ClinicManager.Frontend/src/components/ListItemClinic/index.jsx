import React, { Component } from 'react';

import Card from '../Card';
import './listItemClinic.css';

export default class Index extends Component {
  render() {
    const {
      title,
      address,
      phoneNumber,
      url,
      email,
      specialisation,
      pictureGuid,
      handleClickEditOpen,
      onDeleted,
      handleClickOpenMore
    } = this.props;

    return (
      <Card
        title={title}
        address={address}
        phoneNumber={phoneNumber}
        url={url}
        email={email}
        specialisation={specialisation}
        handleClickEditOpen={handleClickEditOpen}
        onDeleted={onDeleted}
        handleClickOpenMore={handleClickOpenMore}
        pictureGuid={pictureGuid}
      />
    );
  }
}
